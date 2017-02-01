namespace CodeReviewComments.Forms
{
    partial class SelectFileForm
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
            this.filesList = new System.Windows.Forms.ListBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.cancleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filesList
            // 
            this.filesList.FormattingEnabled = true;
            this.filesList.Location = new System.Drawing.Point(12, 12);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(120, 238);
            this.filesList.TabIndex = 0;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(173, 226);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // cancleBtn
            // 
            this.cancleBtn.Location = new System.Drawing.Point(173, 197);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.Size = new System.Drawing.Size(75, 23);
            this.cancleBtn.TabIndex = 2;
            this.cancleBtn.Text = "Cancle";
            this.cancleBtn.UseVisualStyleBackColor = true;
            this.cancleBtn.Click += new System.EventHandler(this.cancleBtn_Click);
            // 
            // SelectFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancleBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.filesList);
            this.Name = "SelectFileForm";
            this.Text = "SelectFileForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox filesList;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button cancleBtn;
    }
}