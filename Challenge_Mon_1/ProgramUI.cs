using System;
using System.Collections.Generic;

namespace Challenge_Mon_1
{
    public class ProgramUI
    {
        List<StreamingContent> _contentList;
        StreamingContentRepository _contentRepo = new StreamingContentRepository();
        int response;

        public void Run()
        {
            _contentRepo.SeedContent();
            _contentList = _contentRepo.GetContentList();
            while (response != 5)
            {
                PrintMenu();
                switch (response)
                {
                    case 1:
                        PrintContent();
                        break;
                    case 2:
                        GetContentInfoFromUser();
                        break;
                    case 3:
                        RemoveContent();
                        break;
                    case 4:
                        EditContent();
                        break;
                    default:
                        break;
                }
            }
        }

        private void EditContent()
        {
            throw new NotImplementedException();
        }

        private void RemoveContent()
        {

        }

        private void PrintContent()
        {
            Console.WriteLine($"Name\t\tContent Type\tRating\tGenre\tDuration");

            for (int i = 0; i < _contentList.Count; i++)
                Console.WriteLine($"{i + 1}{_contentList[i].Name}\t\t{_contentList[i].TypeOfContent}\t{_contentList[i].TypeOfRating}\t{_contentList[i].TypeOfGenre}\t{_contentList[i].Duration}"
                   );
            Console.ReadKey();
        }

        private void GetContentInfoFromUser()
        {
            Console.WriteLine("Enter the name of the content:");
            string name = Console.ReadLine();

            Console.WriteLine($"Enter the {name}'s duration: ");
            double duration = double.Parse(Console.ReadLine());

            Console.WriteLine($"What is the {name}'s rating?\n" +
                "1. PG\n2. G\n3. PG13\n4. R\n5. M\n6. NR");
            var ratingResponse = int.Parse(Console.ReadLine());
            var rating = _contentRepo.GetRating(ratingResponse);

            Console.WriteLine($"What is the {name}'s genre?\n" +
                $"1. Romantic Comedy\n" +
                $"2. Horror\n" +
                $"3. Action\n" +
                $"4. Adventure\n" +
                $"5. Comedy\n" +
                $"6. Science Fiction\n" +
                $"7. Documentary\n" +
                $"8. Mockumentary");
            var genreResponse = int.Parse(Console.ReadLine());
            var genre = _contentRepo.GetGenre(genreResponse);

            Console.WriteLine($"Is {name} a \n1. TV show\n2.  Movie or\n3. Other?");
            var contentResponse = int.Parse(Console.ReadLine());
            var contentType = _contentRepo.GetTypeOfContent(contentResponse);

            StreamingContent content = new StreamingContent(name, contentType, rating, duration, genre);
            _contentRepo.AddContentToList(content);

        }

        public void PrintMenu()
        {
            Console.WriteLine($"What would you like to do?\n\t" +
                $"1. See all content\n\t" +
                $"2. Add content\n\t" +
                $"3. Remove content\n\t" +
                $"4. Edit content\n\t" +
                $"5. Exit");
            response = int.Parse(Console.ReadLine());
        }
    }
}