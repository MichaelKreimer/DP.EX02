namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public partial class BestPostFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestPostFinder));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.radioButtonFormulaStyle = new System.Windows.Forms.RadioButton();
            this.radioButtonCommentsStyle = new System.Windows.Forms.RadioButton();
            this.radioButtonLikesStyle = new System.Windows.Forms.RadioButton();
            this.buttonGenerateResults = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.pictureBoxResultPhoto = new System.Windows.Forms.PictureBox();
            this.textBoxResultInfo = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.groupBoxFormulaInit = new System.Windows.Forms.GroupBox();
            this.labelFormula = new System.Windows.Forms.Label();
            this.labelCommentsValue = new System.Windows.Forms.Label();
            this.labelLikesValue = new System.Windows.Forms.Label();
            this.numericUpDownCommentsValue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLikesValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAllTime = new System.Windows.Forms.RadioButton();
            this.radioButtonLastWeek = new System.Windows.Forms.RadioButton();
            this.radioButtonLastDay = new System.Windows.Forms.RadioButton();
            this.radioButtonLastYear = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownDisplayResults = new System.Windows.Forms.NumericUpDown();
            this.checkedListBoxPostType = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxToSearch = new System.Windows.Forms.TextBox();
            this.groupBoxSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultPhoto)).BeginInit();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxFormulaInit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCommentsValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLikesValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisplayResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSort.Controls.Add(this.radioButtonFormulaStyle);
            this.groupBoxSort.Controls.Add(this.radioButtonCommentsStyle);
            this.groupBoxSort.Controls.Add(this.radioButtonLikesStyle);
            this.groupBoxSort.Controls.Add(this.buttonGenerateResults);
            this.groupBoxSort.Location = new System.Drawing.Point(14, 159);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(223, 84);
            this.groupBoxSort.TabIndex = 30;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Sort By";
            // 
            // radioButtonFormulaStyle
            // 
            this.radioButtonFormulaStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonFormulaStyle.AutoSize = true;
            this.radioButtonFormulaStyle.Location = new System.Drawing.Point(138, 25);
            this.radioButtonFormulaStyle.Name = "radioButtonFormulaStyle";
            this.radioButtonFormulaStyle.Size = new System.Drawing.Size(62, 17);
            this.radioButtonFormulaStyle.TabIndex = 35;
            this.radioButtonFormulaStyle.Text = "Formula";
            this.radioButtonFormulaStyle.UseVisualStyleBackColor = true;
            this.radioButtonFormulaStyle.CheckedChanged += new System.EventHandler(this.radioButtonFormulaStyle_CheckedChanged);
            // 
            // radioButtonCommentsStyle
            // 
            this.radioButtonCommentsStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonCommentsStyle.AutoSize = true;
            this.radioButtonCommentsStyle.Location = new System.Drawing.Point(60, 25);
            this.radioButtonCommentsStyle.Name = "radioButtonCommentsStyle";
            this.radioButtonCommentsStyle.Size = new System.Drawing.Size(74, 17);
            this.radioButtonCommentsStyle.TabIndex = 34;
            this.radioButtonCommentsStyle.Text = "Comments";
            this.radioButtonCommentsStyle.UseVisualStyleBackColor = true;
            this.radioButtonCommentsStyle.CheckedChanged += new System.EventHandler(this.radioButtonCommentsStyle_CheckedChanged);
            // 
            // radioButtonLikesStyle
            // 
            this.radioButtonLikesStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLikesStyle.AutoSize = true;
            this.radioButtonLikesStyle.Checked = true;
            this.radioButtonLikesStyle.Location = new System.Drawing.Point(4, 25);
            this.radioButtonLikesStyle.Name = "radioButtonLikesStyle";
            this.radioButtonLikesStyle.Size = new System.Drawing.Size(50, 17);
            this.radioButtonLikesStyle.TabIndex = 31;
            this.radioButtonLikesStyle.TabStop = true;
            this.radioButtonLikesStyle.Text = "Likes";
            this.radioButtonLikesStyle.UseVisualStyleBackColor = true;
            this.radioButtonLikesStyle.CheckedChanged += new System.EventHandler(this.radioButtonLikesStyle_CheckedChanged);
            // 
            // buttonGenerateResults
            // 
            this.buttonGenerateResults.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonGenerateResults.Location = new System.Drawing.Point(32, 48);
            this.buttonGenerateResults.Name = "buttonGenerateResults";
            this.buttonGenerateResults.Size = new System.Drawing.Size(145, 23);
            this.buttonGenerateResults.TabIndex = 31;
            this.buttonGenerateResults.Text = "Generate Results";
            this.buttonGenerateResults.UseVisualStyleBackColor = true;
            this.buttonGenerateResults.Click += new System.EventHandler(this.buttonGenerateResults_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(0, 19);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(195, 134);
            this.listBoxResult.TabIndex = 38;
            this.listBoxResult.SelectedValueChanged += new System.EventHandler(this.listBoxResult_SelectedValueChanged);
            // 
            // pictureBoxResultPhoto
            // 
            this.pictureBoxResultPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxResultPhoto.Location = new System.Drawing.Point(324, 19);
            this.pictureBoxResultPhoto.Name = "pictureBoxResultPhoto";
            this.pictureBoxResultPhoto.Size = new System.Drawing.Size(134, 134);
            this.pictureBoxResultPhoto.TabIndex = 39;
            this.pictureBoxResultPhoto.TabStop = false;
            // 
            // textBoxResultInfo
            // 
            this.textBoxResultInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxResultInfo.Enabled = false;
            this.textBoxResultInfo.Location = new System.Drawing.Point(201, 19);
            this.textBoxResultInfo.Multiline = true;
            this.textBoxResultInfo.Name = "textBoxResultInfo";
            this.textBoxResultInfo.ReadOnly = true;
            this.textBoxResultInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResultInfo.Size = new System.Drawing.Size(117, 134);
            this.textBoxResultInfo.TabIndex = 40;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxResult.Controls.Add(this.listBoxResult);
            this.groupBoxResult.Controls.Add(this.pictureBoxResultPhoto);
            this.groupBoxResult.Controls.Add(this.textBoxResultInfo);
            this.groupBoxResult.Location = new System.Drawing.Point(14, 250);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(468, 163);
            this.groupBoxResult.TabIndex = 41;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Result";
            // 
            // groupBoxFormulaInit
            // 
            this.groupBoxFormulaInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFormulaInit.Controls.Add(this.labelFormula);
            this.groupBoxFormulaInit.Controls.Add(this.labelCommentsValue);
            this.groupBoxFormulaInit.Controls.Add(this.labelLikesValue);
            this.groupBoxFormulaInit.Controls.Add(this.numericUpDownCommentsValue);
            this.groupBoxFormulaInit.Controls.Add(this.numericUpDownLikesValue);
            this.groupBoxFormulaInit.Enabled = false;
            this.groupBoxFormulaInit.Location = new System.Drawing.Point(254, 159);
            this.groupBoxFormulaInit.Name = "groupBoxFormulaInit";
            this.groupBoxFormulaInit.Size = new System.Drawing.Size(228, 94);
            this.groupBoxFormulaInit.TabIndex = 42;
            this.groupBoxFormulaInit.TabStop = false;
            this.groupBoxFormulaInit.Text = "Formula Initialize";
            // 
            // labelFormula
            // 
            this.labelFormula.AutoSize = true;
            this.labelFormula.Location = new System.Drawing.Point(25, 71);
            this.labelFormula.Name = "labelFormula";
            this.labelFormula.Size = new System.Drawing.Size(147, 13);
            this.labelFormula.TabIndex = 51;
            this.labelFormula.Text = "Score = XLikes + YComments";
            this.labelFormula.Visible = false;
            // 
            // labelCommentsValue
            // 
            this.labelCommentsValue.AutoSize = true;
            this.labelCommentsValue.Location = new System.Drawing.Point(15, 45);
            this.labelCommentsValue.Name = "labelCommentsValue";
            this.labelCommentsValue.Size = new System.Drawing.Size(102, 13);
            this.labelCommentsValue.TabIndex = 50;
            this.labelCommentsValue.Text = "(Y) Comments Value";
            // 
            // labelLikesValue
            // 
            this.labelLikesValue.AutoSize = true;
            this.labelLikesValue.Location = new System.Drawing.Point(15, 17);
            this.labelLikesValue.Name = "labelLikesValue";
            this.labelLikesValue.Size = new System.Drawing.Size(78, 13);
            this.labelLikesValue.TabIndex = 47;
            this.labelLikesValue.Text = "(X) Likes Value";
            // 
            // numericUpDownCommentsValue
            // 
            this.numericUpDownCommentsValue.Enabled = false;
            this.numericUpDownCommentsValue.Location = new System.Drawing.Point(119, 41);
            this.numericUpDownCommentsValue.Name = "numericUpDownCommentsValue";
            this.numericUpDownCommentsValue.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownCommentsValue.TabIndex = 49;
            this.numericUpDownCommentsValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownLikesValue
            // 
            this.numericUpDownLikesValue.Enabled = false;
            this.numericUpDownLikesValue.Location = new System.Drawing.Point(119, 15);
            this.numericUpDownLikesValue.Name = "numericUpDownLikesValue";
            this.numericUpDownLikesValue.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownLikesValue.TabIndex = 48;
            this.numericUpDownLikesValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButtonAllTime);
            this.groupBox1.Controls.Add(this.radioButtonLastWeek);
            this.groupBox1.Controls.Add(this.radioButtonLastDay);
            this.groupBox1.Controls.Add(this.radioButtonLastYear);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDownDisplayResults);
            this.groupBox1.Controls.Add(this.checkedListBoxPostType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxToSearch);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 141);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // radioButtonAllTime
            // 
            this.radioButtonAllTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAllTime.AutoSize = true;
            this.radioButtonAllTime.Checked = true;
            this.radioButtonAllTime.Location = new System.Drawing.Point(69, 112);
            this.radioButtonAllTime.Name = "radioButtonAllTime";
            this.radioButtonAllTime.Size = new System.Drawing.Size(59, 17);
            this.radioButtonAllTime.TabIndex = 49;
            this.radioButtonAllTime.TabStop = true;
            this.radioButtonAllTime.Text = "AllTime";
            this.radioButtonAllTime.UseVisualStyleBackColor = true;
            // 
            // radioButtonLastWeek
            // 
            this.radioButtonLastWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLastWeek.AutoSize = true;
            this.radioButtonLastWeek.Location = new System.Drawing.Point(210, 114);
            this.radioButtonLastWeek.Name = "radioButtonLastWeek";
            this.radioButtonLastWeek.Size = new System.Drawing.Size(77, 17);
            this.radioButtonLastWeek.TabIndex = 48;
            this.radioButtonLastWeek.Text = "Last Week";
            this.radioButtonLastWeek.UseVisualStyleBackColor = true;
            // 
            // radioButtonLastDay
            // 
            this.radioButtonLastDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLastDay.AutoSize = true;
            this.radioButtonLastDay.Location = new System.Drawing.Point(293, 114);
            this.radioButtonLastDay.Name = "radioButtonLastDay";
            this.radioButtonLastDay.Size = new System.Drawing.Size(67, 17);
            this.radioButtonLastDay.TabIndex = 47;
            this.radioButtonLastDay.Text = "Last Day";
            this.radioButtonLastDay.UseVisualStyleBackColor = true;
            // 
            // radioButtonLastYear
            // 
            this.radioButtonLastYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLastYear.AutoSize = true;
            this.radioButtonLastYear.Location = new System.Drawing.Point(134, 112);
            this.radioButtonLastYear.Name = "radioButtonLastYear";
            this.radioButtonLastYear.Size = new System.Drawing.Size(70, 17);
            this.radioButtonLastYear.TabIndex = 46;
            this.radioButtonLastYear.Text = "Last Year";
            this.radioButtonLastYear.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Display results";
            // 
            // numericUpDownDisplayResults
            // 
            this.numericUpDownDisplayResults.Location = new System.Drawing.Point(92, 64);
            this.numericUpDownDisplayResults.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDisplayResults.Name = "numericUpDownDisplayResults";
            this.numericUpDownDisplayResults.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownDisplayResults.TabIndex = 44;
            this.numericUpDownDisplayResults.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // checkedListBoxPostType
            // 
            this.checkedListBoxPostType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxPostType.FormattingEnabled = true;
            this.checkedListBoxPostType.Items.AddRange(new object[] {
            "All"});
            this.checkedListBoxPostType.Location = new System.Drawing.Point(293, 21);
            this.checkedListBoxPostType.Name = "checkedListBoxPostType";
            this.checkedListBoxPostType.Size = new System.Drawing.Size(169, 64);
            this.checkedListBoxPostType.TabIndex = 43;
            this.checkedListBoxPostType.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxPostType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Post Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Text";
            // 
            // textBoxToSearch
            // 
            this.textBoxToSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxToSearch.Location = new System.Drawing.Point(72, 18);
            this.textBoxToSearch.Name = "textBoxToSearch";
            this.textBoxToSearch.Size = new System.Drawing.Size(120, 20);
            this.textBoxToSearch.TabIndex = 38;
            // 
            // BestPostFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 430);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxFormulaInit);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxSort);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "BestPostFinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Best Posts Finder";
            this.groupBoxSort.ResumeLayout(false);
            this.groupBoxSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultPhoto)).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxFormulaInit.ResumeLayout(false);
            this.groupBoxFormulaInit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCommentsValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLikesValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisplayResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.RadioButton radioButtonFormulaStyle;
        private System.Windows.Forms.RadioButton radioButtonCommentsStyle;
        private System.Windows.Forms.RadioButton radioButtonLikesStyle;
        private System.Windows.Forms.Button buttonGenerateResults;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.PictureBox pictureBoxResultPhoto;
        private System.Windows.Forms.TextBox textBoxResultInfo;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.GroupBox groupBoxFormulaInit;
        private System.Windows.Forms.Label labelFormula;
        private System.Windows.Forms.Label labelCommentsValue;
        private System.Windows.Forms.Label labelLikesValue;
        private System.Windows.Forms.NumericUpDown numericUpDownCommentsValue;
        private System.Windows.Forms.NumericUpDown numericUpDownLikesValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownDisplayResults;
        private System.Windows.Forms.CheckedListBox checkedListBoxPostType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxToSearch;
        private System.Windows.Forms.RadioButton radioButtonAllTime;
        private System.Windows.Forms.RadioButton radioButtonLastWeek;
        private System.Windows.Forms.RadioButton radioButtonLastDay;
        private System.Windows.Forms.RadioButton radioButtonLastYear;
    }
}