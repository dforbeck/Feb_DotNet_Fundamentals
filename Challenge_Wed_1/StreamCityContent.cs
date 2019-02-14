namespace Challenge_Wed_1
{
    public enum GenreType { Action, Comedy, Thriller }

    public class StreamCityContent
    {
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

        public StreamCityContent(string name)
        {
            Name = name;
        }
    }
}