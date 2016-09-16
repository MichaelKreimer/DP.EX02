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
using C16_Ex01_Michael_305597478_Shai_300518495;

namespace C16_Ex01_Michael_011112222_Shai_300518495
{
    public partial class FormFacebookConditionally : Form
    {
        public FormFacebookConditionally()
        {
            InitializeComponent();
        }

        private void FormFacebookConditionally_Shown(object sender, EventArgs e)
        {
            bool isInShown = true;
            this.refreshForm(isInShown);
            this.timerPerformCheck.Enabled = true;
            this.timerPerformCheck.Start();
        }

        private void buttonNumOfFetchedPosts_Click(object sender, EventArgs e)
        {
            FacebookService.s_CollectionLimit = (int)numericUpDownPostsToFetch.Value;
            this.refreshForm(false);
        }

        private void timerPerformCheck_Tick(object sender, EventArgs e)
        {
            this.AllButtonsState(false);
            if(this.ScanActions())
            {
                this.refreshForm(false);
            }

            this.timerPerformCheck.Start();
            this.AllButtonsState(true);
        }

        public void AllButtonsState(bool stateSwitch)
        {
            this.buttonCommentAtLeast.Enabled = stateSwitch ? true : false;
            this.buttonCommentTime.Enabled = stateSwitch ? true : false;
            this.buttonDeleteAction.Enabled = stateSwitch ? true : false;
            this.buttonLikeAtLeast.Enabled = stateSwitch ? true : false;
            this.buttonLikeTime.Enabled = stateSwitch ? true : false;
            this.buttonNumOfFetchedPosts.Enabled = stateSwitch ? true : false;
            this.buttonPostTime.Enabled = stateSwitch ? true : false;
            this.buttonUnlike.Enabled = stateSwitch ? true : false;
            this.buttonUnlikeTime.Enabled = stateSwitch ? true : false;
        }

        private void refreshForm(bool isInShown)
        {
            if (isInShown == false)
            {
                this.listBoxPosts.Items.Clear();

                MainForm.s_LoggedInUser.Posts.Clear();

                MainForm.s_LoggedInUser.ReFetch();
            }
            
            foreach (Post post in MainForm.s_LoggedInUser.Posts)
            {
                PostWrapper postw = new PostWrapper(post);
                this.listBoxPosts.Items.Add(postw);
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
                Poster actionToAdd = new Poster(MainForm.s_LoggedInUser, this.dateTimePickerAction.Value, textToPost);
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
                LikerByNums actionToAdd = new LikerByNums(i_isUnlike, handledPost, i_NumOfRequiredLikes, i_NumOfRequiredComments, i_IsAndOperation);
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
                LikerByTime actionToAdd = new LikerByTime(i_IsUnlike, handledPost, this.dateTimePickerAction.Value);
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
                CommenterByNums actionToAdd = new CommenterByNums(this.textBoxPrepareTextToSubmit.Text, handledPost, (int)this.numericUpDownCommentAtLikes.Value, (int)this.numericUpDownCommentAtComments.Value, this.radioButtonCommentAnd.Checked);
                this.listBoxPending.Items.Add(actionToAdd);
            }
        }

        private void buttonCommentTime_Click(object sender, EventArgs e)
        {
            if (isReadyToComment())
            {
                Post handledPost = (this.listBoxPosts.SelectedItem as PostWrapper).Post;
                CommenterByTime actionToAdd = new CommenterByTime(this.textBoxPrepareTextToSubmit.Text, handledPost, this.dateTimePickerAction.Value);
                this.listBoxPending.Items.Add(actionToAdd);
            }
        }

        private bool ScanActions()
        {
            bool isActionInvoked = false;
            List<IFacebookAction> actionsToRemove = new List<IFacebookAction>();
            foreach (object action in this.listBoxPending.Items)
            {
                if ((action as IFacebookAction).IsConditionSatisfied() == true)
                {
                    (action as IFacebookAction).InvokeAction();
                    isActionInvoked = true;
                    actionsToRemove.Add(action as IFacebookAction);
                    this.listBoxDone.Items.Add(action as IFacebookAction);
                }
            }

            foreach (IFacebookAction action in actionsToRemove)
            {
                this.listBoxPending.Items.Remove(action);
            }

            return isActionInvoked;
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
