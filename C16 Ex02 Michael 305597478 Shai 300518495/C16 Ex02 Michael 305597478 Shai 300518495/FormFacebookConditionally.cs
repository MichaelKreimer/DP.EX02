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

namespace C16_Ex02_Michael_305597478_Shai_300518495
{

    public partial class FormFacebookConditionally : Form
    {
        public ITaskFactory TaskFactory { get; set; }
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
            refreshForm();
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
            if (m_IsInShown == false)
            {
                listBoxPosts.Invoke(new Action(() =>
                {
                    this.listBoxPosts.Items.Clear();
                }));

      //TODO      LoginForm.s_LoggedInUserProxy.Clear();

                LoginForm.s_LoggedInUser.ReFetch();
            }
        //    LoginForm.s_LoggedInUserProxy.
            foreach (Post post in LoginForm.s_LoggedInUser.Posts)
            {
                PostWrapper postw = new PostWrapper(post);
                this.listBoxPosts.Items.Add(postw);
            }
            if (m_IsInShown == false)
            {
                m_IsInShown = true;
            }
       }

        private void buttonDeleteAction_Click(object sender, EventArgs e)
        {
            object item = this.listBoxPending.SelectedItem;
            this.listBoxPending.Items.Remove(item);
        }

        private void buttonPostTime_Click(object sender, EventArgs e)
        {
            string textToPost = this.textBoxPrepareTextToSubmit.Text;
            if (textToPost != string.Empty)
            {
                Poster actionToAdd = TaskFactory.CreatePoster(LoginForm.s_LoggedInUser, dateTimePickerAction.Value, textToPost);
                this.listBoxPending.Items.Add(actionToAdd);
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
            if (this.listBoxPosts.SelectedItem != null)
            {
                handledPost = (this.listBoxPosts.SelectedItem as PostWrapper).Post;
                Task actionToAdd = TaskFactory.CreateLikerByNums(i_isUnlike, handledPost, i_NumOfRequiredLikes, i_NumOfRequiredComments, i_IsAndOperation);
                this.listBoxPending.Items.Add(actionToAdd);
            }
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
            if (listBoxPosts.SelectedItem != null)
            {
                handledPost = (this.listBoxPosts.SelectedItem as PostWrapper).Post;
                Task actionToAdd = TaskFactory.CreateLikerByTime(i_IsUnlike, handledPost, this.dateTimePickerAction.Value);
                this.listBoxPending.Items.Add(actionToAdd);
            }
        }

        private bool isReadyToComment()
        {
            return listBoxPosts.SelectedItem != null && this.textBoxPrepareTextToSubmit.Text != string.Empty;
        }

        private void buttonCommentAtLeast_Click(object sender, EventArgs e)
        {
            if (isReadyToComment())
            {
                Post handledPost = (this.listBoxPosts.SelectedItem as PostWrapper).Post;
                Task taskToAdd = TaskFactory.CreateCommenterByNums(this.textBoxPrepareTextToSubmit.Text, handledPost, (int)this.numericUpDownCommentAtLikes.Value, (int)this.numericUpDownCommentAtComments.Value, this.radioButtonCommentAnd.Checked);
                this.listBoxPending.Items.Add(taskToAdd);
            }
        }

        private void buttonCommentTime_Click(object sender, EventArgs e)
        {
            if (isReadyToComment())
            {
                Post handledPost = (this.listBoxPosts.SelectedItem as PostWrapper).Post;
                CommenterByTime taskToAdd = new CommenterByTime(this.textBoxPrepareTextToSubmit.Text, handledPost, this.dateTimePickerAction.Value);
                this.listBoxPending.Items.Add(taskToAdd);
            }
        }

        private bool scanActions()
        {
            bool isTaskInvoked = false;
            foreach (object task in this.listBoxPending.Items)
            {
                isTaskInvoked = (task as Task).Serve();
                tasksToRemove.Add(task as Task);
                this.listBoxDone.Items.Add(task as Task);
            }

            foreach (Task task in tasksToRemove)
            {
                this.listBoxPending.Items.Remove(task);
            }

            return isTaskInvoked;
        }

        private void dateTimePickerAction_ValueChanged(object sender, EventArgs e)
        {
            if(this.dateTimePickerAction.Value <= DateTime.Now)
            {
                this.dateTimePickerAction.Value = DateTime.Now;
            }
        }
    }
}
