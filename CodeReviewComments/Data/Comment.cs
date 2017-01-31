namespace CodeReviewComments.Data
{
    public class Comment
    {
        public string Files { get; set; }
        public CommentType Type { get; set; }
        public string LineNumber { get; set; }
        public string Code { get; set; }
    }
}