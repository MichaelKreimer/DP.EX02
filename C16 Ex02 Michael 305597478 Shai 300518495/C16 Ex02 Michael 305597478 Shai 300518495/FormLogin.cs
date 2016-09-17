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
    public partial class LoginForm : Form
    {
        private BestPostFinder m_BPF = new BestPostFinder();
        private FacebookTaskFactory m_FacebookActionFactory = new FacebookTaskFactory();
        private FormFacebookConditionally m_FC;// = new FormFacebookConditionally(m_FacebookActionFactory);
        public static User s_LoggedInUser {get; set; }

        public LoginForm()
        {
            m_FC = new FormFacebookConditionally(m_FacebookActionFactory);
            InitializeComponent();
        }

// public static UserProxy s_LoggedInUserProxy { get; set; }

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login(
                "162816957481269",
                "public_profile",
                "user_education_history",
                "user_birthday",
                "user_actions.video",
                "user_actions.news",
                "user_actions.music",
                "user_actions.fitness",
                "user_actions.books",
                "user_about_me",
                "user_friends",
                "publish_actions",
                "user_events",
                "user_games_activity",
                "user_hometown",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_photos",
                "user_posts",
                "user_relationships",
                "user_relationship_details",
                "user_religion_politics",
                "user_tagged_places",
                "user_videos",
                "user_website",
                "user_work_history",
                "read_custom_friendlists",
                "read_page_mailboxes",
                "manage_pages",
                "publish_pages",
                "publish_actions",
                "rsvp_event");
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                initUserIsLogged(result);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }
        private void initUserIsLogged(LoginResult result)
        {
            s_LoggedInUser = result.LoggedInUser;
            buttonLogin.Text = "Logged!";
            buttonLogin.Enabled = false;
            buttonPost.Enabled = true;
            textBoxPost.Enabled = true;
            pictureBoxUserProfile.LoadAsync(s_LoggedInUser.PictureNormalURL);
            labelHelloMessage.Text = string.Format("Hello {0} !", s_LoggedInUser.Name);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void buttonBestPostFinder_Click(object sender, EventArgs e)
        {
            runBestPostFinderDialog();
        }

        private void runBestPostFinderDialog()
        {
            if (LoginForm.s_LoggedInUser != null)
            {
                this.Hide();
                m_BPF.ShowDialog();
                this.Show();
            }
        }

        private void buttonFacebookContidional_Click(object sender, EventArgs e)
        {
            if (LoginForm.s_LoggedInUser != null)
            {
                this.Hide();
                m_FC.ShowDialog();
                this.Show();
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            s_LoggedInUser.PostStatus(textBoxPost.Text);
        }
    }
}
