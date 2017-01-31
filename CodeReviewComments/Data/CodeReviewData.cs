using System.Collections.Generic;

namespace CodeReviewComments.Data
{
    public class CodeReviewData
    {
        public CodeReviewData(string issueNumber)
        {
            IssueNumber = issueNumber;
        }

        public string IssueNumber { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}