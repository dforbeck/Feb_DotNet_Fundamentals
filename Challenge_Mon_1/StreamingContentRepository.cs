using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Mon_1
{
   public class StreamingContentRepository
    {
        List<StreamingContent> _contentList = new List<StreamingContent>();

        public List<StreamingContent> GetContentList()
        {
            return _contentList;
        }

        public void SeedContent()
        {
            _contentList.Add(new StreamingContent("Star Wars", ContentType.Movie, RatingType.PG, 128, GenreType.SciFy));
            _contentList.Add(new StreamingContent("Bob's Burgers", ContentType.Show, RatingType.PG, 25, GenreType.Comedy));
            _contentList.Add(new StreamingContent("Life of Birds", ContentType.Show, RatingType.G, 60, GenreType.Documentary));
        }

        public void AddContentToList(StreamingContent content)
        {
            _contentList.Add(content);
        }

        public void RemoveContentFromList(int index)
        {
            StreamingContent content = _contentList[index];
            _contentList.Remove(content);
        }

        public RatingType GetRating(int response)
        {
            RatingType rating;
            switch (response)
            {
                case 1:
                    rating = RatingType.PG;
                    break;
                case 2:
                    rating = RatingType.G;
                    break;
                case 3:
                    rating = RatingType.PG13;
                    break;
                case 4:
                    rating = RatingType.R;
                    break;
                case 5:
                    rating = RatingType.M;
                    break;
                default:
                    rating = RatingType.NR;
                    break;
            }
            return rating;
        }

        public GenreType GetGenre(int response)
        {
            GenreType genre;
            switch (response)
            {
                case 1:
                    genre = GenreType.RomCom;
                    break;
                case 2:
                    genre = GenreType.Horror;
                    break;
                case 3:
                    genre = GenreType.Action;
                    break;
                case 4:
                    genre = GenreType.Adventure;
                    break;
                case 5:
                    genre = GenreType.Comedy;
                    break;
                case 6:
                    genre = GenreType.SciFy;
                    break;
                case 7:
                    genre = GenreType.Documentary;
                    break;
                default:
                    genre = GenreType.Mockumentary;
                    break;
            }
            return genre;
        }

        public ContentType GetTypeOfContent(int response)
        {
            ContentType content;
            switch (response)
            {
                case 1:
                    content = ContentType.Show;
                    break;
                case 2:
                    content = ContentType.Movie;
                    break;
                default:
                    content = ContentType.Other;
                    break;
            }
            return content;
        }
    }
}
