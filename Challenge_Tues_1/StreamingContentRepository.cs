using System;
using System.Collections.Generic;

namespace Challenge_Tues_1
{
    //This is where we will house our methods that do not require Console.
    internal class StreamingContentRepository
    {
        List<StreamingContent> _contentList;

        public List<StreamingContent> GetContentList()
        {
            _contentList = new List<StreamingContent>();
            return _contentList;
        }

        public void AddContentToList(StreamingContent content)
        {
            _contentList.Add(content);
        }

        public GenreType GetGenreFromInt(int genreInput)
        {
            GenreType genre;
            switch (genreInput)
            {
                case 1:
                    genre = GenreType.Action;
                    break;
                case 2:
                    genre = GenreType.Comedy;
                    break;
                case 3:
                    genre = GenreType.Thriller;
                    break;
                default:
                    genre = GenreType.Comedy;
                    break;
            }
            return genre;
        }

        internal void RemoveContentFromList(StreamingContent content)
        {
            _contentList.Remove(content);
        }
    }
}