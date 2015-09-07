using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Reader
{
    public class News
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Descrition { get; set; }
        public string PubDate { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.AppendLine(Descrition);
            sb.AppendLine(PubDate);
            sb.AppendLine(Category);
            sb.AppendLine("------------");
            return sb.ToString();
        }
    }
}
