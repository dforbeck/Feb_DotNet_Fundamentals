using System;
using System.Collections.Generic;

namespace Challenge_Tues_1
{
    //This is the program interface where menus and console-based helper methods are housed.
    internal class ProgramUI
    {
        StreamingContentRepository _contentRepo = new StreamingContentRepository();
        List<StreamingContent> _listOfContent;
        int _response;

        internal void Run()
        {
            _listOfContent = _contentRepo.GetContentList();
            SeedData();
            while (_response != 4)
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

        private void RemoveContent()
        {
            SeeAllContent();
            Console.WriteLine("Enter the name of the content you would like to remove:");
            string desiredName = Console.ReadLine();
            foreach(StreamingContent content in _listOfContent)
            {
                if (content.Name == desiredName)
                {
                    _contentRepo.RemoveContentFromList(content);
                    break;
                }
            }
        }

        private void SeedData()
        {
            _contentRepo.AddContentToList(new StreamingContent("Star Wars", 2.1, GenreType.Action, true));
            _contentRepo.AddContentToList(new StreamingContent("Bob's Burgers", .5, GenreType.Comedy, false));
            _contentRepo.AddContentToList(new StreamingContent("Transformers", 2.4, GenreType.Action, true));
            _contentRepo.AddContentToList(new StreamingContent("American Horror Story", 1, GenreType.Thriller, false));
        }

        private void SeeAllContent()
        {
            Console.WriteLine("Content Name\tContent Duration\tGenre\tIs it a Movie?");
            foreach (StreamingContent content in _listOfContent)
            {
                Console.WriteLine($"{content.Name}\t{content.Duration} Hours\t\t{content.TypeOfGenre}\t{content.IsMovie}");
            }
            
        }

        public void PrintMenu()
        {
            Console.WriteLine("What would you like to do?\n\t" +
                "1. See all content\n\t" +
                "2. Add new content\n\t" +
                "3. Remove content\n\t" +
                "4. Exit");
            string responseStr = Console.ReadLine();
            _response = int.Parse(responseStr);
        }

        public void GetUserInput()
        {
            StreamingContent newContent = new StreamingContent();

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
            GenreType genre = _contentRepo.GetGenreFromInt(genreInt);
            newContent.TypeOfGenre = genre;

            _contentRepo.AddContentToList(newContent);
        }
    }
}