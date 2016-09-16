using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public partial class FormFacebookConditionally
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacebookConditionally));
            this.dateTimePickerAction = new System.Windows.Forms.DateTimePicker();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listBoxPending = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPostTime = new System.Windows.Forms.Button();
            this.textBoxPrepareTextToSubmit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCommentTime = new System.Windows.Forms.Button();
            this.buttonLikeTime = new System.Windows.Forms.Button();
            this.buttonLikeAtLeast = new System.Windows.Forms.Button();
            this.buttonCommentAtLeast = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownLikeAtLikes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLikeAtComments = new System.Windows.Forms.NumericUpDown();
            this.radioButtonLikeAnd = new System.Windows.Forms.RadioButton();
            this.radioButtonLikeOr = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButtonCommentOr = new System.Windows.Forms.RadioButton();
            this.radioButtonCommentAnd = new System.Windows.Forms.RadioButton();
            this.numericUpDownCommentAtComments = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCommentAtLikes = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonDeleteAction = new System.Windows.Forms.Button();
            this.buttonNumOfFetchedPosts = new System.Windows.Forms.Button();
            this.numericUpDownPostsToFetch = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listBoxDone = new System.Windows.Forms.ListBox();
            this.timerPerformCheck = new System.Windows.Forms.Timer(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonUnlike = new System.Windows.Forms.Button();
            this.buttonUnlikeTime = new System.Windows.Forms.Button();
            this.groupBoxNumOf = new System.Windows.Forms.GroupBox();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLikeAtLikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLikeAtComments)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCommentAtComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCommentAtLikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPostsToFetch)).BeginInit();
            this.groupBoxNumOf.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerAction
            // 
            this.dateTimePickerAction.CustomFormat = "MMM d yyyy \'at\' HH\':\'mm";
            this.dateTimePickerAction.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAction.Location = new System.Drawing.Point(4, 30);
            this.dateTimePickerAction.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerAction.Name = "dateTimePickerAction";
            this.dateTimePickerAction.Size = new System.Drawing.Size(157, 20);
            this.dateTimePickerAction.TabIndex = 0;
            this.dateTimePickerAction.ValueChanged += new System.EventHandler(this.dateTimePickerAction_ValueChanged);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(15, 26);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(335, 186);
            this.listBoxPosts.TabIndex = 1;
            // 
            // listBoxPending
            // 
            this.listBoxPending.FormattingEnabled = true;
            this.listBoxPending.Location = new System.Drawing.Point(371, 26);
            this.listBoxPending.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPending.Name = "listBoxPending";
            this.listBoxPending.Size = new System.Drawing.Size(335, 186);
            this.listBoxPending.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Posts:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pending Actions:";
            // 
            // buttonPostTime
            // 
            this.buttonPostTime.Location = new System.Drawing.Point(532, 16);
            this.buttonPostTime.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPostTime.Name = "buttonPostTime";
            this.buttonPostTime.Size = new System.Drawing.Size(152, 45);
            this.buttonPostTime.TabIndex = 5;
            this.buttonPostTime.Text = "New Post By Time";
            this.buttonPostTime.UseVisualStyleBackColor = true;
            this.buttonPostTime.Click += new System.EventHandler(this.buttonPostTime_Click);
            // 
            // textBoxPrepareTextToSubmit
            // 
            this.textBoxPrepareTextToSubmit.Location = new System.Drawing.Point(15, 476);
            this.textBoxPrepareTextToSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrepareTextToSubmit.Multiline = true;
            this.textBoxPrepareTextToSubmit.Name = "textBoxPrepareTextToSubmit";
            this.textBoxPrepareTextToSubmit.Size = new System.Drawing.Size(335, 134);
            this.textBoxPrepareTextToSubmit.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 461);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type Post Or Comment:";
            // 
            // buttonCommentTime
            // 
            this.buttonCommentTime.Location = new System.Drawing.Point(348, 16);
            this.buttonCommentTime.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCommentTime.Name = "buttonCommentTime";
            this.buttonCommentTime.Size = new System.Drawing.Size(180, 45);
            this.buttonCommentTime.TabIndex = 8;
            this.buttonCommentTime.Text = "Comment On Chosen Post By Time";
            this.buttonCommentTime.UseVisualStyleBackColor = true;
            this.buttonCommentTime.Click += new System.EventHandler(this.buttonCommentTime_Click);
            // 
            // buttonLikeTime
            // 
            this.buttonLikeTime.Location = new System.Drawing.Point(164, 16);
            this.buttonLikeTime.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLikeTime.Name = "buttonLikeTime";
            this.buttonLikeTime.Size = new System.Drawing.Size(180, 21);
            this.buttonLikeTime.TabIndex = 9;
            this.buttonLikeTime.Text = "Like Chosen Post By Time";
            this.buttonLikeTime.UseVisualStyleBackColor = true;
            this.buttonLikeTime.Click += new System.EventHandler(this.buttonLikeTime_Click);
            // 
            // buttonLikeAtLeast
            // 
            this.buttonLikeAtLeast.Location = new System.Drawing.Point(14, 18);
            this.buttonLikeAtLeast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLikeAtLeast.Name = "buttonLikeAtLeast";
            this.buttonLikeAtLeast.Size = new System.Drawing.Size(47, 26);
            this.buttonLikeAtLeast.TabIndex = 10;
            this.buttonLikeAtLeast.Text = "Like";
            this.buttonLikeAtLeast.UseVisualStyleBackColor = true;
            this.buttonLikeAtLeast.Click += new System.EventHandler(this.buttonLikeAtLeast_Click);
            // 
            // buttonCommentAtLeast
            // 
            this.buttonCommentAtLeast.Location = new System.Drawing.Point(14, 52);
            this.buttonCommentAtLeast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCommentAtLeast.Name = "buttonCommentAtLeast";
            this.buttonCommentAtLeast.Size = new System.Drawing.Size(100, 26);
            this.buttonCommentAtLeast.TabIndex = 11;
            this.buttonCommentAtLeast.Text = "Comment";
            this.buttonCommentAtLeast.UseVisualStyleBackColor = true;
            this.buttonCommentAtLeast.Click += new System.EventHandler(this.buttonCommentAtLeast_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "when there are At Least";
            // 
            // numericUpDownLikeAtLikes
            // 
            this.numericUpDownLikeAtLikes.Location = new System.Drawing.Point(241, 23);
            this.numericUpDownLikeAtLikes.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownLikeAtLikes.Name = "numericUpDownLikeAtLikes";
            this.numericUpDownLikeAtLikes.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownLikeAtLikes.TabIndex = 15;
            // 
            // numericUpDownLikeAtComments
            // 
            this.numericUpDownLikeAtComments.Location = new System.Drawing.Point(479, 23);
            this.numericUpDownLikeAtComments.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownLikeAtComments.Name = "numericUpDownLikeAtComments";
            this.numericUpDownLikeAtComments.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownLikeAtComments.TabIndex = 16;
            // 
            // radioButtonLikeAnd
            // 
            this.radioButtonLikeAnd.AutoSize = true;
            this.radioButtonLikeAnd.Checked = true;
            this.radioButtonLikeAnd.Location = new System.Drawing.Point(4, 5);
            this.radioButtonLikeAnd.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonLikeAnd.Name = "radioButtonLikeAnd";
            this.radioButtonLikeAnd.Size = new System.Drawing.Size(48, 17);
            this.radioButtonLikeAnd.TabIndex = 17;
            this.radioButtonLikeAnd.TabStop = true;
            this.radioButtonLikeAnd.Text = "AND";
            this.radioButtonLikeAnd.UseVisualStyleBackColor = true;
            // 
            // radioButtonLikeOr
            // 
            this.radioButtonLikeOr.AutoSize = true;
            this.radioButtonLikeOr.Location = new System.Drawing.Point(60, 5);
            this.radioButtonLikeOr.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonLikeOr.Name = "radioButtonLikeOr";
            this.radioButtonLikeOr.Size = new System.Drawing.Size(41, 17);
            this.radioButtonLikeOr.TabIndex = 18;
            this.radioButtonLikeOr.Text = "OR";
            this.radioButtonLikeOr.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.radioButtonLikeOr);
            this.panel1.Controls.Add(this.radioButtonLikeAnd);
            this.panel1.Location = new System.Drawing.Point(324, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 26);
            this.panel1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Likes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Comments on the chosen post.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Comments on the chosen post.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Likes";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.radioButtonCommentOr);
            this.panel2.Controls.Add(this.radioButtonCommentAnd);
            this.panel2.Location = new System.Drawing.Point(324, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 26);
            this.panel2.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(47, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "/";
            // 
            // radioButtonCommentOr
            // 
            this.radioButtonCommentOr.AutoSize = true;
            this.radioButtonCommentOr.Location = new System.Drawing.Point(60, 5);
            this.radioButtonCommentOr.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCommentOr.Name = "radioButtonCommentOr";
            this.radioButtonCommentOr.Size = new System.Drawing.Size(41, 17);
            this.radioButtonCommentOr.TabIndex = 18;
            this.radioButtonCommentOr.Text = "OR";
            this.radioButtonCommentOr.UseVisualStyleBackColor = true;
            // 
            // radioButtonCommentAnd
            // 
            this.radioButtonCommentAnd.AutoSize = true;
            this.radioButtonCommentAnd.Checked = true;
            this.radioButtonCommentAnd.Location = new System.Drawing.Point(4, 5);
            this.radioButtonCommentAnd.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCommentAnd.Name = "radioButtonCommentAnd";
            this.radioButtonCommentAnd.Size = new System.Drawing.Size(48, 17);
            this.radioButtonCommentAnd.TabIndex = 17;
            this.radioButtonCommentAnd.TabStop = true;
            this.radioButtonCommentAnd.Text = "AND";
            this.radioButtonCommentAnd.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCommentAtComments
            // 
            this.numericUpDownCommentAtComments.Location = new System.Drawing.Point(479, 57);
            this.numericUpDownCommentAtComments.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownCommentAtComments.Name = "numericUpDownCommentAtComments";
            this.numericUpDownCommentAtComments.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownCommentAtComments.TabIndex = 25;
            // 
            // numericUpDownCommentAtLikes
            // 
            this.numericUpDownCommentAtLikes.Location = new System.Drawing.Point(241, 57);
            this.numericUpDownCommentAtLikes.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownCommentAtLikes.Name = "numericUpDownCommentAtLikes";
            this.numericUpDownCommentAtLikes.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownCommentAtLikes.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(118, 58);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "when there are At Least";
            // 
            // buttonDeleteAction
            // 
            this.buttonDeleteAction.Location = new System.Drawing.Point(371, 214);
            this.buttonDeleteAction.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteAction.Name = "buttonDeleteAction";
            this.buttonDeleteAction.Size = new System.Drawing.Size(107, 26);
            this.buttonDeleteAction.TabIndex = 29;
            this.buttonDeleteAction.Text = "Delete Action";
            this.buttonDeleteAction.UseVisualStyleBackColor = true;
            this.buttonDeleteAction.Click += new System.EventHandler(this.buttonDeleteAction_Click);
            // 
            // buttonNumOfFetchedPosts
            // 
            this.buttonNumOfFetchedPosts.Location = new System.Drawing.Point(15, 214);
            this.buttonNumOfFetchedPosts.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNumOfFetchedPosts.Name = "buttonNumOfFetchedPosts";
            this.buttonNumOfFetchedPosts.Size = new System.Drawing.Size(56, 26);
            this.buttonNumOfFetchedPosts.TabIndex = 30;
            this.buttonNumOfFetchedPosts.Text = "Fetch";
            this.buttonNumOfFetchedPosts.UseVisualStyleBackColor = true;
            this.buttonNumOfFetchedPosts.Click += new System.EventHandler(this.buttonNumOfFetchedPosts_Click);
            // 
            // numericUpDownPostsToFetch
            // 
            this.numericUpDownPostsToFetch.Location = new System.Drawing.Point(75, 217);
            this.numericUpDownPostsToFetch.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownPostsToFetch.Name = "numericUpDownPostsToFetch";
            this.numericUpDownPostsToFetch.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownPostsToFetch.TabIndex = 31;
            this.numericUpDownPostsToFetch.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(125, 221);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "last Posts.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(369, 461);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Done Actions:";
            // 
            // listBoxDone
            // 
            this.listBoxDone.FormattingEnabled = true;
            this.listBoxDone.Location = new System.Drawing.Point(371, 476);
            this.listBoxDone.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxDone.Name = "listBoxDone";
            this.listBoxDone.Size = new System.Drawing.Size(335, 134);
            this.listBoxDone.TabIndex = 33;
            // 
            // timerPerformCheck
            // 
            this.timerPerformCheck.Interval = 30000;
            this.timerPerformCheck.Tick += new System.EventHandler(this.timerPerformCheck_Tick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(431, 25);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "At Least";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(431, 58);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "At Least";
            // 
            // buttonUnlike
            // 
            this.buttonUnlike.Location = new System.Drawing.Point(67, 18);
            this.buttonUnlike.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUnlike.Name = "buttonUnlike";
            this.buttonUnlike.Size = new System.Drawing.Size(47, 26);
            this.buttonUnlike.TabIndex = 37;
            this.buttonUnlike.Text = "Unlike";
            this.buttonUnlike.UseVisualStyleBackColor = true;
            this.buttonUnlike.Click += new System.EventHandler(this.buttonUnlike_Click);
            // 
            // buttonUnlikeTime
            // 
            this.buttonUnlikeTime.Location = new System.Drawing.Point(164, 41);
            this.buttonUnlikeTime.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUnlikeTime.Name = "buttonUnlikeTime";
            this.buttonUnlikeTime.Size = new System.Drawing.Size(180, 21);
            this.buttonUnlikeTime.TabIndex = 38;
            this.buttonUnlikeTime.Text = "Unlike Chosen Post By Time";
            this.buttonUnlikeTime.UseVisualStyleBackColor = true;
            this.buttonUnlikeTime.Click += new System.EventHandler(this.buttonUnlikeTime_Click);
            // 
            // groupBoxNumOf
            // 
            this.groupBoxNumOf.Controls.Add(this.buttonUnlike);
            this.groupBoxNumOf.Controls.Add(this.buttonLikeAtLeast);
            this.groupBoxNumOf.Controls.Add(this.buttonCommentAtLeast);
            this.groupBoxNumOf.Controls.Add(this.label15);
            this.groupBoxNumOf.Controls.Add(this.label4);
            this.groupBoxNumOf.Controls.Add(this.label14);
            this.groupBoxNumOf.Controls.Add(this.numericUpDownLikeAtLikes);
            this.groupBoxNumOf.Controls.Add(this.numericUpDownLikeAtComments);
            this.groupBoxNumOf.Controls.Add(this.panel1);
            this.groupBoxNumOf.Controls.Add(this.label6);
            this.groupBoxNumOf.Controls.Add(this.label7);
            this.groupBoxNumOf.Controls.Add(this.label11);
            this.groupBoxNumOf.Controls.Add(this.numericUpDownCommentAtLikes);
            this.groupBoxNumOf.Controls.Add(this.label5);
            this.groupBoxNumOf.Controls.Add(this.numericUpDownCommentAtComments);
            this.groupBoxNumOf.Controls.Add(this.label9);
            this.groupBoxNumOf.Controls.Add(this.panel2);
            this.groupBoxNumOf.Location = new System.Drawing.Point(15, 261);
            this.groupBoxNumOf.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxNumOf.Name = "groupBoxNumOf";
            this.groupBoxNumOf.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxNumOf.Size = new System.Drawing.Size(690, 87);
            this.groupBoxNumOf.TabIndex = 39;
            this.groupBoxNumOf.TabStop = false;
            this.groupBoxNumOf.Text = "Number of Likes / Comments  condition";
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.buttonLikeTime);
            this.groupBoxTime.Controls.Add(this.dateTimePickerAction);
            this.groupBoxTime.Controls.Add(this.buttonUnlikeTime);
            this.groupBoxTime.Controls.Add(this.buttonPostTime);
            this.groupBoxTime.Controls.Add(this.buttonCommentTime);
            this.groupBoxTime.Location = new System.Drawing.Point(15, 367);
            this.groupBoxTime.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTime.Size = new System.Drawing.Size(690, 73);
            this.groupBoxTime.TabIndex = 0;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Time condition";
            // 
            // FormFacebookConditionally
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 627);
            this.Controls.Add(this.groupBoxTime);
            this.Controls.Add(this.groupBoxNumOf);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listBoxDone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericUpDownPostsToFetch);
            this.Controls.Add(this.buttonNumOfFetchedPosts);
            this.Controls.Add(this.buttonDeleteAction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrepareTextToSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPending);
            this.Controls.Add(this.listBoxPosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFacebookConditionally";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Conditional Actions";
            this.Shown += new System.EventHandler(this.FormFacebookConditionally_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLikeAtLikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLikeAtComments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCommentAtComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCommentAtLikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPostsToFetch)).EndInit();
            this.groupBoxNumOf.ResumeLayout(false);
            this.groupBoxNumOf.PerformLayout();
            this.groupBoxTime.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerAction;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ListBox listBoxPending;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPostTime;
        private System.Windows.Forms.TextBox textBoxPrepareTextToSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCommentTime;
        private System.Windows.Forms.Button buttonLikeTime;
        private System.Windows.Forms.Button buttonLikeAtLeast;
        private System.Windows.Forms.Button buttonCommentAtLeast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownLikeAtLikes;
        private System.Windows.Forms.NumericUpDown numericUpDownLikeAtComments;
        private System.Windows.Forms.RadioButton radioButtonLikeAnd;
        private System.Windows.Forms.RadioButton radioButtonLikeOr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButtonCommentOr;
        private System.Windows.Forms.RadioButton radioButtonCommentAnd;
        private System.Windows.Forms.NumericUpDown numericUpDownCommentAtComments;
        private System.Windows.Forms.NumericUpDown numericUpDownCommentAtLikes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonDeleteAction;
        private System.Windows.Forms.Button buttonNumOfFetchedPosts;
        private System.Windows.Forms.NumericUpDown numericUpDownPostsToFetch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBoxDone;
        private System.Windows.Forms.Timer timerPerformCheck;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonUnlike;
        private System.Windows.Forms.Button buttonUnlikeTime;
        private System.Windows.Forms.GroupBox groupBoxNumOf;
        private System.Windows.Forms.GroupBox groupBoxTime;
    }
}