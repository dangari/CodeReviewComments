using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CodeReviewComments.Core;
using CodeReviewComments.Data;
using CodeReviewComments.Forms;

namespace CodeReviewComments
{
    public partial class CodeReviewTool : Form
    {
        private readonly CodeReview m_CodeReview;
        private string m_SelectedComment = string.Empty;

        public CodeReviewTool()
        {
            InitializeComponent();
            m_CodeReview = new CodeReview(OnChange);
            commentList.DataSource = m_CodeReview.CommentInds;
            commentType.DataSource = typeof(CommentType).GetEnumNames();
            commentType.SelectedIndex = 0;
        }

        private void saveComment_Click(object sender, EventArgs e)
        {
            //todo: Add error handling
            try
            {
                CommentType type = (CommentType) Enum.Parse(typeof(CommentType), commentType.SelectedItem.ToString(), true);
                int lineNumber = string.IsNullOrEmpty(lineNumberText.Text) ? 0 : int.Parse(lineNumberText.Text);
                string fileName = fileNameText.Text;
                string text = commentBox.Text;
                string code = codeTextBox.Text;

                if (string.IsNullOrEmpty(m_SelectedComment))
                {
                    m_CodeReview.AddComment(type, fileName, lineNumber, text, code);
                }
                else
                {
                    m_CodeReview.EditComment(m_SelectedComment, type, fileName, lineNumber, text, code);
                }

                m_CodeReview.SetIssueNumber(issueNumberText.Text);

                m_SelectedComment = string.Empty;
                OnChange();
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
            codeTextBox.Text = comment.Code;
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
            IList<string> paths = Directory.GetFiles(path, "*.crw");
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
            codeTextBox.Text = string.Empty;
            issueNumberText.Text = m_CodeReview.GetIssueNumber();
            commentList.ClearSelected();
        }

        private void commentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommentType type = (CommentType)Enum.Parse(typeof(CommentType), commentType.SelectedItem.ToString(), true);

            switch (type)
            {
                case CommentType.Refactor:
                    fileNameText.Enabled = true;
                    lineNumberText.Enabled = true;
                    codeTextBox.Enabled = true;
                    commentBox.Enabled = true;
                    break;
                case CommentType.UnusedDirectives:
                    fileNameText.Enabled = true;
                    lineNumberText.Enabled = false;
                    lineNumberText.Text = string.Empty;
                    codeTextBox.Enabled = false;
                    codeTextBox.Text = string.Empty;
                    commentBox.Enabled = false;
                    commentBox.Text = string.Empty;
                    break;
                case CommentType.Comment:
                    fileNameText.Enabled = true;
                    commentBox.Enabled = true;
                    lineNumberText.Enabled = false;
                    lineNumberText.Text = string.Empty;
                    codeTextBox.Enabled = false;
                    codeTextBox.Text = string.Empty;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void exportMarkUpBtn_Click(object sender, EventArgs e)
        {
            string markUp = m_CodeReview.GetMarkUp();
            MarkExport form = new MarkExport(markUp);
            form.ShowDialog();
        }
    }
}
