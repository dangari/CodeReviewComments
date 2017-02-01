namespace CodeReviewComments
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.reviewCode = new System.Windows.Forms.TabPage();
            this.saveComment = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lineNumberText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileNameText = new System.Windows.Forms.TextBox();
            this.commentBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.commentType = new System.Windows.Forms.ComboBox();
            this.commentList = new System.Windows.Forms.ListBox();
            this.codeReviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.issueNumberText = new System.Windows.Forms.TextBox();
            this.fixCode = new System.Windows.Forms.TabPage();
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.editReview = new System.Windows.Forms.Button();
            this.saveReview = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.reviewCode.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeReviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.reviewCode);
            this.tabControl1.Controls.Add(this.fixCode);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // reviewCode
            // 
            this.reviewCode.Controls.Add(this.saveComment);
            this.reviewCode.Controls.Add(this.panel1);
            this.reviewCode.Controls.Add(this.commentList);
            this.reviewCode.Controls.Add(this.label1);
            this.reviewCode.Controls.Add(this.issueNumberText);
            this.reviewCode.Location = new System.Drawing.Point(4, 22);
            this.reviewCode.Name = "reviewCode";
            this.reviewCode.Padding = new System.Windows.Forms.Padding(3);
            this.reviewCode.Size = new System.Drawing.Size(666, 434);
            this.reviewCode.TabIndex = 0;
            this.reviewCode.Text = "Review Code";
            this.reviewCode.UseVisualStyleBackColor = true;
            // 
            // saveComment
            // 
            this.saveComment.Location = new System.Drawing.Point(537, 405);
            this.saveComment.Name = "saveComment";
            this.saveComment.Size = new System.Drawing.Size(92, 23);
            this.saveComment.TabIndex = 4;
            this.saveComment.Text = "Save Comment";
            this.saveComment.UseVisualStyleBackColor = true;
            this.saveComment.Click += new System.EventHandler(this.saveComment_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lineNumberText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.fileNameText);
            this.panel1.Controls.Add(this.commentBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.commentType);
            this.panel1.Location = new System.Drawing.Point(46, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 326);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Start Line Number";
            // 
            // lineNumberText
            // 
            this.lineNumberText.Location = new System.Drawing.Point(377, 41);
            this.lineNumberText.Name = "lineNumberText";
            this.lineNumberText.Size = new System.Drawing.Size(55, 20);
            this.lineNumberText.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "File Name";
            // 
            // fileNameText
            // 
            this.fileNameText.Location = new System.Drawing.Point(86, 42);
            this.fileNameText.Name = "fileNameText";
            this.fileNameText.Size = new System.Drawing.Size(132, 20);
            this.fileNameText.TabIndex = 9;
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(3, 73);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(451, 250);
            this.commentBox.TabIndex = 8;
            this.commentBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type";
            // 
            // commentType
            // 
            this.commentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commentType.Items.AddRange(new object[] {
            "Refactor",
            "UnusedDirectives",
            "Comment"});
            this.commentType.Location = new System.Drawing.Point(86, 10);
            this.commentType.Name = "commentType";
            this.commentType.Size = new System.Drawing.Size(132, 21);
            this.commentType.TabIndex = 6;
            // 
            // commentList
            // 
            this.commentList.DataSource = this.codeReviewBindingSource;
            this.commentList.FormattingEnabled = true;
            this.commentList.Location = new System.Drawing.Point(509, 32);
            this.commentList.Name = "commentList";
            this.commentList.Size = new System.Drawing.Size(120, 368);
            this.commentList.TabIndex = 2;
            this.commentList.SelectedIndexChanged += new System.EventHandler(this.commentList_SelectedIndexChanged);
            // 
            // codeReviewBindingSource
            // 
            this.codeReviewBindingSource.DataSource = typeof(CodeReviewComments.Core.CodeReview);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Issue Number";
            // 
            // issueNumberText
            // 
            this.issueNumberText.Location = new System.Drawing.Point(118, 32);
            this.issueNumberText.Name = "issueNumberText";
            this.issueNumberText.Size = new System.Drawing.Size(132, 20);
            this.issueNumberText.TabIndex = 0;
            // 
            // fixCode
            // 
            this.fixCode.Location = new System.Drawing.Point(4, 22);
            this.fixCode.Name = "fixCode";
            this.fixCode.Padding = new System.Windows.Forms.Padding(3);
            this.fixCode.Size = new System.Drawing.Size(666, 434);
            this.fixCode.TabIndex = 1;
            this.fixCode.Text = "Fix Code";
            this.fixCode.UseVisualStyleBackColor = true;
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.DataSource = typeof(CodeReviewComments.Form1);
            // 
            // editReview
            // 
            this.editReview.Location = new System.Drawing.Point(17, 479);
            this.editReview.Name = "editReview";
            this.editReview.Size = new System.Drawing.Size(75, 23);
            this.editReview.TabIndex = 5;
            this.editReview.Text = "Edit Review";
            this.editReview.UseVisualStyleBackColor = true;
            this.editReview.Click += new System.EventHandler(this.editReview_Click);
            // 
            // saveReview
            // 
            this.saveReview.Location = new System.Drawing.Point(98, 479);
            this.saveReview.Name = "saveReview";
            this.saveReview.Size = new System.Drawing.Size(86, 23);
            this.saveReview.TabIndex = 6;
            this.saveReview.Text = "Save Review";
            this.saveReview.UseVisualStyleBackColor = true;
            this.saveReview.Click += new System.EventHandler(this.saveReview_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(CodeReviewComments.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 508);
            this.Controls.Add(this.saveReview);
            this.Controls.Add(this.editReview);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.reviewCode.ResumeLayout(false);
            this.reviewCode.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeReviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage reviewCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox issueNumberText;
        private System.Windows.Forms.TabPage fixCode;
        private System.Windows.Forms.Button saveComment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lineNumberText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileNameText;
        private System.Windows.Forms.RichTextBox commentBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox commentType;
        private System.Windows.Forms.ListBox commentList;
        private System.Windows.Forms.Button editReview;
        private System.Windows.Forms.Button saveReview;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource codeReviewBindingSource;
    }
}

