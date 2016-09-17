using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Threading;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{

    public partial class FormFacebookConditionally : Form
    {
        public ITaskFactory TaskFactory { get; set; }
        private readonly object m_lockComment = new object();
        private readonly object m_lockLike = new object();
        private readonly object m_lockShown = new object();
        private readonly object m_lockList = new object();
        private readonly object m_lockText = new object();

        List<Task> tasksToRemove = new List<Task>();
        private bool m_IsInShown;
        public FormFacebookConditionally(ITaskFactory i_TaskFactory)
        {
            this.TaskFactory = i_TaskFactory;
            InitializeComponent();
        }

        private void FormFacebookConditionally_Shown(object sender, EventArgs e)
        {
            // m_IsInShown = true;
            Thread thread = new Thread(refreshForm);
            thread.Start();
         //   refreshForm();
            this.timerPerformCheck.Enabled = true;
            this.timerPerformCheck.Start();
        }

        private void buttonNumOfFetchedPosts_Click(object sender, EventArgs e)
        {
            FacebookService.s_CollectionLimit = (int)numericUpDownPostsToFetch.Value;
            this.refreshForm();
        }

        private void timerPerformCheck_Tick(object sender, EventArgs e)
        {
            this.AllButtonsState(false);
            if(this.scanActions())
            {
                this.refreshForm();
            }

            this.timerPerformCheck.Start();
            this.AllButtonsState(true);
        }

        public void AllButtonsState(bool stateSwitch)
        {
            this.buttonCommentAtLeast.Enabled = this.buttonCommentTime.Enabled = this.buttonDeleteAction.Enabled =
            this.buttonLikeAtLeast.Enabled = this.buttonLikeTime.Enabled = this.buttonNumOfFetchedPosts.Enabled =
            this.buttonPostTime.Enabled = this.buttonUnlike.Enabled = this.buttonUnlikeTime.Enabled = stateSwitch;
        }

        private void refreshForm()
        {
            lock (m_lockShown)
            {
                if (m_IsInShown == false)
                {
                    clearListAsynchronous(listBoxPosts);

                    //Check with shay     LoginForm.s_LoggedInUser.Posts.Clear();

                    LoginForm.s_LoggedInUser.ReFetch();
                }
            }
        //    LoginForm.s_LoggedInUserProxy.
            foreach (Post post in LoginForm.s_LoggedInUser.Posts)
            {
                PostWrapper postw = new PostWrapper(post);
                addObjectToListBoxAsynchronous(listBoxPosts, postw);
            }
            lock (m_lockShown)
            {
                if (m_IsInShown == false)
                {
                    m_IsInShown = true;
                }
            }
       }

        private void buttonDeleteAction_Click(object sender, EventArgs e)
        {
            object item = this.listBoxPending.SelectedItem;
            listBoxPending.Invoke(new Action(() =>
            {
                this.listBoxPending.Items.Remove(item);
            }));
        }

        private void buttonPostTime_Click(object sender, EventArgs e)
        {
            string textToPost = this.textBoxPrepareTextToSubmit.Text;
            lock (m_lockText)
            {
                if (textToPost != string.Empty)
                {
                    Poster taskToAdd = TaskFactory.CreatePoster(LoginForm.s_LoggedInUser, dateTimePickerAction.Value, textToPost);
                    addObjectToListBoxAsynchronous(listBoxPending, taskToAdd);
                }
            }
        }

        private void buttonLikeAtLeast_Click(object sender, EventArgs e)
        {
            likerByNumFilters(false, (int)this.numericUpDownLikeAtLikes.Value, (int)this.numericUpDownLikeAtComments.Value, this.radioButtonLikeAnd.Checked);
        }

        private void buttonUnlike_Click(object sender, EventArgs e)
        {
            likerByNumFilters(true, (int)this.numericUpDownLikeAtLikes.Value, (int)this.numericUpDownLikeAtComments.Value, this.radioButtonLikeAnd.Checked);
        }

        private void likerByNumFilters(bool i_isUnlike, int i_NumOfRequiredLikes, int i_NumOfRequiredComments, bool i_IsAndOperation)
        {
            Post handledPost;
            lock (m_lockList)
            {
                if (this.listBoxPosts.SelectedItem != null)
                {
                    handledPost = (this.listBoxPosts.SelectedItem as PostWrapper).Post;
                    Task taskToAdd = TaskFactory.CreateLikerByNums(i_isUnlike, handledPost, i_NumOfRequiredLikes, i_NumOfRequiredComments, i_IsAndOperation);
                    addObjectToListBoxAsynchronous(listBoxPending, taskToAdd);
                }
            }
        }
        private void addObjectToListBoxAsynchronous(ListBox i_ListBox,object i_Object)
        {
            i_ListBox.Invoke(new Action(() =>
            {
                i_ListBox.Items.Add(i_Object);
            }));
        }
        private void clearListAsynchronous(ListBox i_ListBox)
        {
            i_ListBox.Invoke(new Action(() =>
            {
                i_ListBox.Items.Clear();
            }));

        }
        private void removeItemFromListBoxAsynchronous(ListBox i_ListBox, object i_Object)
        {
            i_ListBox.Items.Remove(i_Object);
        }
        private void buttonLikeTime_Click(object sender, EventArgs e)
        {
            LikerByTimeFilters(false, this.dateTimePickerAction.Value);
        }

        private void buttonUnlikeTime_Click(object sender, EventArgs e)
        {
            LikerByTimeFilters(true, this.dateTimePickerAction.Value);
        }

        private void LikerByTimeFilters(bool i_IsUnlike, DateTime i_ChosenDateTime)
        {
            Post handledPost;
            lock (m_lockList)
            {
                if (listBoxPosts.SelectedItem != null)
                {
                    handledPost = (this.listBoxPosts.SelectedItem as PostWrapper).Post;
                    Task taskToAdd = TaskFactory.CreateLikerByTime(i_IsUnlike, handledPost, this.dateTimePickerAction.Value);
                    addObjectToListBoxAsynchronous(listBoxPending, taskToAdd);
                }
            }
        }

        private bool isReadyToComment()
        {
            return listBoxPosts.SelectedItem != null && this.textBoxPrepareTextToSubmit.Text != string.Empty;
        }

        private void buttonCommentAtLeast_Click(object sender, EventArgs e)
        {
            lock(m_lockComment)
            {
                if (isReadyToComment())
                {
                    Post handledPost = (this.listBoxPosts.SelectedItem as PostWrapper).Post;
                    Task taskToAdd = TaskFactory.CreateCommenterByNums(this.textBoxPrepareTextToSubmit.Text, handledPost, (int)this.numericUpDownCommentAtLikes.Value, (int)this.numericUpDownCommentAtComments.Value, this.radioButtonCommentAnd.Checked);
                    addObjectToListBoxAsynchronous(listBoxPending, taskToAdd);
                }
            }
        }

        private void buttonCommentTime_Click(object sender, EventArgs e)
        {
            lock (m_lockComment)
            {
                if (isReadyToComment())
                {
                    Post handledPost = (this.listBoxPosts.SelectedItem as PostWrapper).Post;
                    CommenterByTime taskToAdd = new CommenterByTime(this.textBoxPrepareTextToSubmit.Text, handledPost, this.dateTimePickerAction.Value);
                    addObjectToListBoxAsynchronous(listBoxPending, taskToAdd);

                }
            }
        }

        private bool scanActions()
        {
            bool isTaskInvoked = false;
            foreach (object obj in this.listBoxPending.Items)
            {
                Task task = obj as Task;
                lock (m_lockList)
                {
                    isTaskInvoked = task.Serve();
                    if (isTaskInvoked == true)
                    {
                        tasksToRemove.Add(task);
                        addObjectToListBoxAsynchronous(listBoxDone, task);
                    }
                }
            }

            foreach (Task task in tasksToRemove)
            {
                // this.listBoxPending.Items.Remove(task);
                removeItemFromListBoxAsynchronous(listBoxPending, task);
            }

            return isTaskInvoked;
        }

        private void dateTimePickerAction_ValueChanged(object sender, EventArgs e)
        {
                if (this.dateTimePickerAction.Value <= DateTime.Now)
                {
                    this.dateTimePickerAction.Value = DateTime.Now;
                }
        }
    }
}
