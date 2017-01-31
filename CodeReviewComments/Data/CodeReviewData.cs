using System.Collections.Generic;
using System.Xml.Serialization;

namespace CodeReviewComments.Data
{
    [XmlRoot]
    public class CodeReviewData
    {
        public class CommentDicItems
        {
            [XmlAttribute]
            public string Key { get; set; }

            [XmlElement]
            public Comment Comment { get; set; }
        }

        [XmlElement]
        public string IssueNumber { get; set; }

        [XmlIgnore]
        public Dictionary<string, Comment> Comments { get; set; } = new Dictionary<string, Comment>();

        [XmlElement]
        public List<CommentDicItems> CommentDic { get; set; }

        public void CreateSerializeDic()
        {
            CommentDic = new List<CommentDicItems>();
            foreach (var item in Comments)
            {
                CommentDic.Add(new CommentDicItems {Comment = item.Value , Key = item.Key});
            }
        }
    }
}