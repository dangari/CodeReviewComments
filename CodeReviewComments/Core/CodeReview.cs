﻿using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using CodeReviewComments.Data;

namespace CodeReviewComments.Core
{
    public class CodeReview
    {
        public readonly CodeReviewData m_Data;
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
            Comment comment = new Comment {Type = type, FileName = fileName, LineNumber = lineNumber, Text = text};
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
                    string path = $"{Directory.GetCurrentDirectory().Replace("bin\\", string.Empty).Replace("Debug", string.Empty).Replace("Release", string.Empty)}\\CodeReviews\\";
                    Directory.CreateDirectory(path);
                    File.WriteAllText($"{path}{fileName}.xml", xml);
                }
            }
        }
    }
}