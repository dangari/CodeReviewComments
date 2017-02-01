using System;
using System.Windows.Forms;

namespace CodeReviewComments.Forms
{
    public partial class MarkExport : Form
    {
        public MarkExport(string markUp)
        {
            InitializeComponent();
            markUpTextBox.Text = markUp;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(markUpTextBox.Text);
        }
    }
}
