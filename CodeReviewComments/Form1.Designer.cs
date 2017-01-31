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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.reviewCode = new System.Windows.Forms.TabPage();
            this.fixCode = new System.Windows.Forms.TabPage();
            this.issueNumberText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveComment = new System.Windows.Forms.Button();
            this.editReview = new System.Windows.Forms.Button();
            this.saveReview = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.reviewCode.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.reviewCode.Controls.Add(this.listBox1);
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
            // issueNumberText
            // 
            this.issueNumberText.Location = new System.Drawing.Point(118, 32);
            this.issueNumberText.Name = "issueNumberText";
            this.issueNumberText.Size = new System.Drawing.Size(132, 20);
            this.issueNumberText.TabIndex = 0;
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(509, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 368);
            this.listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(46, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 326);
            this.panel1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(451, 250);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 9;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(377, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 11;
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
            // saveComment
            // 
            this.saveComment.Location = new System.Drawing.Point(537, 405);
            this.saveComment.Name = "saveComment";
            this.saveComment.Size = new System.Drawing.Size(92, 23);
            this.saveComment.TabIndex = 4;
            this.saveComment.Text = "Save Comment";
            this.saveComment.UseVisualStyleBackColor = true;
            // 
            // editReview
            // 
            this.editReview.Location = new System.Drawing.Point(17, 479);
            this.editReview.Name = "editReview";
            this.editReview.Size = new System.Drawing.Size(75, 23);
            this.editReview.TabIndex = 5;
            this.editReview.Text = "Edit Review";
            this.editReview.UseVisualStyleBackColor = true;
            // 
            // saveReview
            // 
            this.saveReview.Location = new System.Drawing.Point(98, 479);
            this.saveReview.Name = "saveReview";
            this.saveReview.Size = new System.Drawing.Size(86, 23);
            this.saveReview.TabIndex = 6;
            this.saveReview.Text = "Save Review";
            this.saveReview.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button editReview;
        private System.Windows.Forms.Button saveReview;
    }
}

