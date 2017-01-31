using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CodeReviewComments.Core;
using CodeReviewComments.Data;

namespace CodeReviewComments
{
    public partial class Form1 : Form
    {
        private readonly CodeReview m_CodeReview;
        private string m_SelectedComment = string.Empty;
        public Form1()
        {
            InitializeComponent();
            m_CodeReview = new CodeReview();
            commentList.DataSource = m_CodeReview.CommentInds;
        }

        private void saveComment_Click(object sender, EventArgs e)
        {
            CommentType type = (CommentType) Enum.Parse(typeof(CommentType), commentType.SelectedItem.ToString(), true);
            int lineNumber = int.Parse(lineNumberText.Text);
            string fileName = fileNameText.Text;
            string text = commentBox.Text;

            if (string.IsNullOrEmpty(m_SelectedComment))
            {
                m_CodeReview.AddComment(type, fileName, lineNumber, text);
            }
            else
            {
                m_CodeReview.EditComment(m_SelectedComment, type, fileName, lineNumber, text);
            }

            m_SelectedComment = string.Empty;
        }

        private void commentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_SelectedComment = commentList.Text;
            Comment comment = m_CodeReview.LoadComment(m_SelectedComment);
            commentType.Text = comment.Type.ToString();
            lineNumberText.Text = comment.LineNumber.ToString();
            fileNameText.Text = comment.FileName;
            commentBox.Text = comment.Text;
        }
    }
}
