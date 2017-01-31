namespace CodeReviewComments.Data
{
    public class Comment
    {
        public Comment(CommentType type, string fileName, int lineNumber, string text)
        {
            Type = type;
            FileName = fileName;
            LineNumber = lineNumber;
            Text = text;
        }

        public string FileName { get; set; }
        public CommentType Type { get; set; }
        public int LineNumber { get; set; }
        public string Text { get; set; }
    }
}