using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Mon_1
{
    public enum ContentType { Show, Movie, Other}
    public enum RatingType {PG, G, PG13, R, M, NR }
    public enum GenreType { RomCom, Horror, Action, Adventure, Comedy, SciFy, Documentary, Mockumentary}

    public class StreamingContent
    {
        public string Name { get; set; }
        public ContentType TypeOfContent { get; set; }
        public RatingType TypeOfRating { get; set; }
        public double Duration { get; set; }
        public GenreType TypeOfGenre { get; set; }

        public StreamingContent()
        {

        }

        public StreamingContent(string name, ContentType content, RatingType rating, double duration, GenreType genre)
        {
            Name = name;
            TypeOfContent = content;
            TypeOfRating = rating;
            TypeOfGenre = genre;
            Duration = duration;
        }
    }
}
