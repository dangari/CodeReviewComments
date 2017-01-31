using System.ComponentModel;
using CodeReviewComments.Data;

namespace CodeReviewComments.Core
{
    public class CodeReview
    {
        private readonly CodeReviewData m_Data;
        private int m_CommentCount;
        public BindingList<string> CommentInds { get; }

        public CodeReview()
        {
            m_Data = new CodeReviewData();
            m_CommentCount = 0;
            CommentInds = new BindingList<string> ();
        }

        public void AddComment(CommentType type, string fileName, int lineNumber, string text)
        {
            Comment comment = new Comment(type, fileName, lineNumber, text);
            string commentInd = $"Comment_{m_CommentCount}";
            m_Data.Comments.Add(commentInd, comment);
            ++m_CommentCount;
            CommentInds.Add(commentInd);
        }

        public void EditComment(string commentName, CommentType type, string fileName, int lineNumber, string text)
        {
            Comment comment = m_Data.Comments[commentName];
            comment.Type = type;
            comment.FileName = fileName;
            comment.LineNumber = lineNumber;
            comment.Text = text;
        }

        public Comment LoadComment(string commentName)
        {
            return m_Data.Comments[commentName];
        }
    }
}