using HtmlAgilityPack;
using System.Linq;

namespace Weather
{
    static class Utils
    {
        public static string CleanText(this string text)
        {
            char[] alphaNumeric = new char[]
                    {
                        'a','b','c','d','e','f','g','h','i','j','k',
                        'l','m','n','o','p','q','r','s','t','u','v',
                        'w','x','y','z','1','2','3','4','5','6','7','8','9','0',
                        '.',',',' ','?','\'', '-'
                    };
            text = text.Replace("%20", " ");
            text = text.RemoveHTMLTags();
            string result = "";
            foreach (char c in text)
            {
                char letter = c.ToString().ToLower()[0];
                if (alphaNumeric.Contains(letter))
                {
                    result += c;
                }
                else
                {
                    result += " ";
                }
            }

            result = result.Replace("   ", " ").Replace("  ", " ").Trim();

            return result;
        }

        public static string RemoveHTMLTags(this string text)
        {
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(text);
            string innerText = document.DocumentNode.InnerText;
            return innerText;
        }
    }
}
