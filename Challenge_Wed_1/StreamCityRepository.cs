using System.Collections.Generic;
using static Challenge_Wed_1.StreamCityContent;

namespace Challenge_Wed_1
{
    internal class StreamCityRepository
    {
        List<StreamCityContent> _contentList;
        Queue<StreamCityContent> _contentQueue;

        //List Methods
        public List<StreamCityContent> GetContentList()
        {
            _contentList = new List<StreamCityContent>();
            return _contentList;
        }

        public void AddContentToList(StreamCityContent content)
        {
            _contentList.Add(content);
        }

        public void RemoveContentFromList(StreamCityContent content)
        {
            _contentList.Remove(content);
        }

        //Queue Methods
        public Queue<StreamCityContent> GetContentQueue()
        {
            _contentQueue = new Queue<StreamCityContent>();
            return _contentQueue;
        }

        public void AddContentToQueue(StreamCityContent content)
        {
            _contentQueue.Enqueue(content);
        }

        public void DequeueContentFromQueue()
        {
            _contentQueue.Dequeue();
        }

        //Other Methods
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
    }
}