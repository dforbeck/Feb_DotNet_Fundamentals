using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Wed_1
{
    class Essay
    {
        public string Title { get; set; }
        public string Thesis { get; set; }
        public string AuthorName { get; set; }
        public int NumOfParagraphs { get; set; }
        public string References { get; set; }

        public Essay()
        {

        }

        public Essay(string title, string thesis, string name, int numParagraphs, string citations)
        {
            Title = title;
            Thesis = thesis;
            AuthorName = name;
            NumOfParagraphs = numParagraphs;
            References = citations;
        }

    }
}
