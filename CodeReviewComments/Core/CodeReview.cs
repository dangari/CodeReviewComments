using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using CodeReviewComments.Data;

namespace CodeReviewComments.Core
{
    public class CodeReview
    {
        private CodeReviewData m_Data;
        private readonly Action m_OnChange;
        
        private int m_CommentCount;
        private readonly string m_Path;

        public BindingList<string> CommentInds { get; set; }

        public CodeReview(Action onChange)
        {
            m_Path = $"{Directory.GetCurrentDirectory().Replace("bin\\", string.Empty).Replace("Debug", string.Empty).Replace("Release", string.Empty)}\\CodeReviews\\";
            m_Data = new CodeReviewData();
            m_CommentCount = 0;
            CommentInds = new BindingList<string> ();
            m_OnChange = onChange;
        }

        public void SetIssueNumber(string issueNumber)
        {
            m_Data.IssueNumber = issueNumber;
        }

        public string GetIssueNumber()
        {
            return m_Data.IssueNumber;
        }

        public void AddComment(CommentType type, string fileName, int lineNumber, string text, string code)
        {
            Comment comment = new Comment {Type = type, FileName = fileName, LineNumber = lineNumber, Text = text, Code = code};
            string commentInd = $"Comment_{m_CommentCount}";
            m_Data.Comments.Add(commentInd, comment);
            ++m_CommentCount;
            CommentInds.Add(commentInd);
        }

        public void EditComment(string commentName, CommentType type, string fileName, int lineNumber, string text, string code)
        {
            Comment comment = m_Data.Comments[commentName];
            comment.Type = type;
            comment.FileName = fileName;
            comment.LineNumber = lineNumber;
            comment.Text = text;
            comment.Code = code;
        }

        public Comment LoadComment(string commentName)
        {
            return m_Data.Comments[commentName];
        }

        public void SaveComments(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CodeReviewData));
            string xml;
            m_Data.CreateSerializeDic();
            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xmlSerializer.Serialize(writer, m_Data);
                    xml = sww.ToString(); // Your XML
                    Directory.CreateDirectory(m_Path);
                    File.WriteAllText($"{m_Path}{fileName}.crw", xml);
                }
            }
        }

        public void LoadData(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CodeReviewData));
            using (StreamReader reader = new StreamReader($"{m_Path}{fileName}"))
            {
                m_Data = (CodeReviewData) xmlSerializer.Deserialize(reader);
                m_Data.CreateDeserializeDic();
                ReloadCommentList();
                m_OnChange();
            }
        }

        private void ReloadCommentList()
        {
            CommentInds.Clear();

            foreach (var item in m_Data.Comments)
            {
                CommentInds.Add(item.Key);
            }
        }
    }
}