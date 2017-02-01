using System.Collections.Generic;
using System.Windows.Forms;
using CodeReviewComments.Core;

namespace CodeReviewComments.Forms
{
    public partial class SelectFileForm : Form
    {
        private readonly CodeReview m_CodeReview;

        public SelectFileForm(IList<string> files, CodeReview codeReview)
        {
            InitializeComponent();
            filesList.DataSource = files;
            m_CodeReview = codeReview;
        }

        private void loadBtn_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(filesList.Text))
            {
                m_CodeReview.LoadData(filesList.Text);
            }

            Close();
        }

        private void cancleBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
