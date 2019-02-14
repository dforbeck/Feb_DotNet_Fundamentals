using System;
using System.Collections.Generic;
using static Challenge_Wed_1.StreamCityContent;

namespace Challenge_Wed_1
{
    internal class ProgramUI
    {
        StreamCityRepository _streamCityRepo = new StreamCityRepository();
        List<StreamCityContent> _contentList;
        Queue<StreamCityContent> _contentQueue;

        int _response;

        internal void Run()
        {
            _contentList = _streamCityRepo.GetContentList();
            _contentQueue = _streamCityRepo.GetContentQueue();
            SeedData();
            while (_response != 7)
            {
                PrintMenu();
                switch (_response)
                {
                    case 1:
                        SeeAllContent();
                        break;
                    case 2:
                        GetUserInput();
                        break;
                    case 3:
                        RemoveContent();
                        break;
                    case 4:
                        SeeAllContent();
                        Console.WriteLine("Enter the name of the content you would like to watch later:");
                        var desiredContent = Console.ReadLine();
                        foreach (var content in _contentList)
                        {
                            if (desiredContent.ToLower() == content.Name.ToLower())
                            {
                                _streamCityRepo.AddContentToQueue(content);
                                break;
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine($"You just watched {_contentQueue.Peek().Name}!");
                        _streamCityRepo.DequeueContentFromQueue();
                        break;
                    case 6:
                        PrintQueue();
                        break;
                    case 7:
                        Console.WriteLine("Have a nice day!");
                        break;
                    default:
                        Console.WriteLine("Please enter an appropriate number.");
                        break;
                }
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void PrintQueue()
        {
            Console.WriteLine("Content Name\tContent Duration\tGenre\tIs it a Movie?");
            foreach (var content in _contentQueue)
                Console.WriteLine($"{content.Name}\t{content.Duration} Hours\t\t{content.TypeOfGenre}\t{content.IsMovie}"); ;
        }

        private void RemoveContent()
        {
            SeeAllContent();
            Console.WriteLine("Enter the name of the content you would like to remove:");
            string desiredName = Console.ReadLine();
            foreach (StreamCityContent content in _contentList)
            {
                if (content.Name == desiredName)
                {
                    _streamCityRepo.RemoveContentFromList(content);
                    break;
                }
            }
        }

        private void SeedData()
        {
            _streamCityRepo.AddContentToList(new StreamCityContent("Star Wars", 2.1, GenreType.Action, true));
            _streamCityRepo.AddContentToList(new StreamCityContent("Bob's Burgers", .5, GenreType.Comedy, false));
            _streamCityRepo.AddContentToList(new StreamCityContent("Transformers", 2.4, GenreType.Action, true));
            _streamCityRepo.AddContentToList(new StreamCityContent("American Horror Story", 1, GenreType.Thriller, false));
        }

        private void SeeAllContent()
        {
            Console.WriteLine("Content Name\tContent Duration\tGenre\tIs it a Movie?");
            foreach (StreamCityContent content in _contentList)
                Console.WriteLine($"{content.Name}\t{content.Duration} Hours\t\t{content.TypeOfGenre}\t{content.IsMovie}");
        }

        public void PrintMenu()
        {
            Console.WriteLine("What would you like to do?\n\t" +
                "1. See all content\n\t" +
                "2. Add new content\n\t" +
                "3. Remove content\n\t" +
                "4. Add content to queue\n\t" +
                "5. Watch content\n\t" +
                "6. See all content in queue\n\t" +
                "7. Exit");
            string responseStr = Console.ReadLine();
            _response = int.Parse(responseStr);
        }

        public void GetUserInput()
        {
            StreamCityContent newContent = new StreamCityContent();

            Console.WriteLine("Enter the name of your content:");
            string name = Console.ReadLine();
            newContent.Name = name;

            Console.WriteLine("How long is the content in hours?");
            double duration = double.Parse(Console.ReadLine());
            newContent.Duration = duration;

            Console.WriteLine("Is your content a movie? y/n");
            string isMovieStr = Console.ReadLine().ToLower();
            bool isMovie;
            if (isMovieStr.Contains("y"))
                isMovie = true;
            else
                isMovie = false;
            newContent.IsMovie = isMovie;

            Console.WriteLine("What genre is your content?\n\t" +
                "1. Action\n\t" +
                "2. Comedy\n\t" +
                "3. Thriller");
            int genreInt = int.Parse(Console.ReadLine());
            GenreType genre = _streamCityRepo.GetGenreFromInt(genreInt);
            newContent.TypeOfGenre = genre;

            _streamCityRepo.AddContentToList(newContent);
        }
    }
}