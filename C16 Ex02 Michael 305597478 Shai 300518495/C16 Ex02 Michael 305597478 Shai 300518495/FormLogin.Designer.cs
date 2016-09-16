namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonFacebookContidional = new System.Windows.Forms.Button();
            this.buttonBestPostFinder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            this.labelHelloMessage = new System.Windows.Forms.Label();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(212, 201);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(118, 40);
            this.buttonLogin.TabIndex = 13;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonFacebookContidional
            // 
            this.buttonFacebookContidional.Location = new System.Drawing.Point(270, 29);
            this.buttonFacebookContidional.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFacebookContidional.Name = "buttonFacebookContidional";
            this.buttonFacebookContidional.Size = new System.Drawing.Size(254, 35);
            this.buttonFacebookContidional.TabIndex = 14;
            this.buttonFacebookContidional.Text = "Facebook Conditional Actions";
            this.buttonFacebookContidional.UseVisualStyleBackColor = true;
            this.buttonFacebookContidional.Click += new System.EventHandler(this.buttonFacebookContidional_Click);
            // 
            // buttonBestPostFinder
            // 
            this.buttonBestPostFinder.Location = new System.Drawing.Point(8, 29);
            this.buttonBestPostFinder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBestPostFinder.Name = "buttonBestPostFinder";
            this.buttonBestPostFinder.Size = new System.Drawing.Size(254, 35);
            this.buttonBestPostFinder.TabIndex = 15;
            this.buttonBestPostFinder.Text = "Best Post Finder";
            this.buttonBestPostFinder.UseVisualStyleBackColor = true;
            this.buttonBestPostFinder.Click += new System.EventHandler(this.buttonBestPostFinder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFacebookContidional);
            this.groupBox1.Controls.Add(this.buttonBestPostFinder);
            this.groupBox1.Location = new System.Drawing.Point(7, 358);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(537, 80);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Feature";
            // 
            // pictureBoxUserProfile
            // 
            this.pictureBoxUserProfile.Location = new System.Drawing.Point(200, 42);
            this.pictureBoxUserProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
            this.pictureBoxUserProfile.Size = new System.Drawing.Size(178, 152);
            this.pictureBoxUserProfile.TabIndex = 17;
            this.pictureBoxUserProfile.TabStop = false;
            // 
            // labelHelloMessage
            // 
            this.labelHelloMessage.AutoSize = true;
            this.labelHelloMessage.Location = new System.Drawing.Point(207, 17);
            this.labelHelloMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHelloMessage.Name = "labelHelloMessage";
            this.labelHelloMessage.Size = new System.Drawing.Size(100, 20);
            this.labelHelloMessage.TabIndex = 18;
            this.labelHelloMessage.Text = "Please Login";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Enabled = false;
            this.textBoxPost.Location = new System.Drawing.Point(15, 260);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(429, 81);
            this.textBoxPost.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Text to post:";
            // 
            // buttonPost
            // 
            this.buttonPost.Enabled = false;
            this.buttonPost.Location = new System.Drawing.Point(450, 260);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(81, 81);
            this.buttonPost.TabIndex = 21;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 453);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.labelHelloMessage);
            this.Controls.Add(this.pictureBoxUserProfile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonFacebookContidional;
        private System.Windows.Forms.Button buttonBestPostFinder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxUserProfile;
        private System.Windows.Forms.Label labelHelloMessage;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPost;
    }
}