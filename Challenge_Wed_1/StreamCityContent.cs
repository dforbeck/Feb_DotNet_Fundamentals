namespace Challenge_Wed_1
{
    public class StreamCityContent
    {
        public enum GenreType { Action, Comedy, Thriller }

        public string Name { get; set; }
        public double Duration { get; set; }
        public GenreType TypeOfGenre { get; set; }
        public bool IsMovie { get; set; }

        public StreamCityContent()
        {

        }

        public StreamCityContent(string name, double duration, GenreType genreType, bool isMovie)
        {
            Name = name;
            Duration = duration;
            TypeOfGenre = genreType;
            IsMovie = isMovie;
        }
    }
}