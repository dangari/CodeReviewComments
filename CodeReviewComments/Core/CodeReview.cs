using CodeReviewComments.Data;

namespace CodeReviewComments.Core
{
    public class CodeReview
    {
        private CodeReviewData m_Data;

        public CodeReview(string issueNumber)
        {
            m_Data = new CodeReviewData(issueNumber);
        }

        public void AddComment()
        {
            
        }
    }
}