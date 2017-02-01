using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using CodeReviewComments.Core;
using CodeReviewComments.Data;
using CodeReviewComments.Forms;

namespace CodeReviewComments
{
    public partial class Form1 : Form
    {
        private readonly CodeReview m_CodeReview;
        private string m_SelectedComment = string.Empty;

        public Form1()
        {
            InitializeComponent();
            m_CodeReview = new CodeReview(OnChange);
            commentList.DataSource = m_CodeReview.CommentInds;
        }

        private void saveComment_Click(object sender, EventArgs e)
        {
            //todo: Add error handling
            try
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
            catch (Exception err)
            {
                MessageBox.Show(
                    $"An Error has been occured while trying to save \n {err.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void commentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_SelectedComment = commentList.Text;
            if (string.IsNullOrEmpty(m_SelectedComment))
            {
                return;
            }

            Comment comment = m_CodeReview.LoadComment(m_SelectedComment);
            commentType.Text = comment.Type.ToString();
            lineNumberText.Text = comment.LineNumber.ToString();
            fileNameText.Text = comment.FileName;
            commentBox.Text = comment.Text;
        }

        private void saveReview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(issueNumberText.Text))
            {
                MessageBox.Show(
                    "Issue Name is Needed",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            m_CodeReview.SetIssueNumber(issueNumberText.Text);
            m_CodeReview.SaveComments(issueNumberText.Text);
        }

        private void editReview_Click(object sender, EventArgs e)
        {
            string path =
                $"{Directory.GetCurrentDirectory().Replace("bin\\", string.Empty).Replace("Debug", string.Empty).Replace("Release", string.Empty)}\\CodeReviews\\";
            IList<string> paths = Directory.GetFiles(path);
            paths = paths.Select(x => x.Replace(path, string.Empty)).ToList();

            var form = new SelectFileForm(paths, m_CodeReview);
            form.ShowDialog();
        }

        private void OnChange()
        {
            commentType.Text = string.Empty;
            lineNumberText.Text = string.Empty;
            fileNameText.Text = string.Empty;
            commentBox.Text = string.Empty;
            issueNumberText.Text = m_CodeReview.GetIssueNumber();
            commentList.ClearSelected();
        }
    }
}
