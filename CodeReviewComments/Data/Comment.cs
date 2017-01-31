using System.Xml.Serialization;

namespace CodeReviewComments.Data
{
    public class Comment
    {
        [XmlElement]
        public string FileName { get; set; }

        [XmlAttribute]
        public CommentType Type { get; set; }

        [XmlElement]
        public int LineNumber { get; set; }

        [XmlElement]
        public string Text { get; set; }
    }
}