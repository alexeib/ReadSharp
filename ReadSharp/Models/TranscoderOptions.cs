using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ReadSharp.Models
{
    public class TranscoderOptions
    {
        /// <summary>
        /// A dictionary of url matching regex as key to html element selector as value that represents hints for the transcoder to be able to find the actual article content within downlaoded HTML
        /// </summary>
        public IDictionary<Regex, string> ArticleElementHints { get; set; }

        public TranscoderOptions()
        {
            ArticleElementHints = new Dictionary<Regex, string>();
        }
    }
}
