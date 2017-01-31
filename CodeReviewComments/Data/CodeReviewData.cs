using System.Collections.Generic;

namespace CodeReviewComments.Data
{
    public class CodeReviewData
    {
        public string IssueNumber { get; set; }
        public Dictionary<string, Comment> Comments { get; } = new Dictionary<string, Comment>();
    }
}