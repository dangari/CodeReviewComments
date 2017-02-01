using System.Collections.Generic;
using System.Linq;
using CodeReviewComments.Data;

namespace CodeReviewComments.Core
{
    public class MarkUpGenerator
    {
        public static string GenerateMarkup(CodeReviewData codeReviewData)
        {
            string comment = string.Empty;
            foreach (var commentItem in SortComments(codeReviewData.Comments))
            {
                comment += $"\'\'\'{commentItem.Key}.cs\'\'\'\n";
                IList<Comment> comments = commentItem.Value.OrderBy(x => x.Type).ToList();

                foreach (var item in comments)
                {
                    switch (item.Type)
                    {
                        case CommentType.Refactor:
                            comment += $"{item.Text}\n";
                            comment += GenerateCode(item) + "\n";
                            break;
                        case CommentType.UnusedDirectives:
                            comment += "unused directive \n\n";
                            break;
                        case CommentType.Comment:
                            comment += $"{item.Text}\n\n";
                            break;
                    }
                }
            }
            
            return comment;
        }

        private static Dictionary<string, IList<Comment>> SortComments(Dictionary<string, Comment> comments)
        {
            Dictionary<string, IList<Comment>> sortedComments = new Dictionary<string, IList<Comment>>();
            foreach (var item in comments)
            {
                if (sortedComments.ContainsKey(item.Value.FileName))
                {
                    sortedComments[item.Value.FileName].Add(item.Value);
                }
                else
                {
                    sortedComments.Add(item.Value.FileName, new List<Comment> {item.Value});
                }
            }

            return sortedComments;
        }

        private static string GenerateCode(Comment comment)
        {
            string[] lines = comment.Code.Split('\n');
            string code = string.Empty;
            if (comment.LineNumber != 0)
            {
                int lineCount = comment.LineNumber;
                foreach (string line in lines)
                {
                    code += $"{lineCount}: {line} \n";
                    ++lineCount;
                }
            }
            else
            {
                code = comment.Code;
            }

            string codeHeader = "{code:lang=csharp}";
            string codeEnd = "{code}\n";

            return $"{codeHeader}\n{code}{codeEnd}";
        }
    }
}