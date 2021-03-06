﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Tues_1
{
    public enum GenreType { Action, Comedy, Thriller}

    //This is our baseline object that the program is working with.
    public class StreamingContent
    {
        //This is where we will define the expectations for our properties and methods of the object.
        public string Name { get; set; }
        public double Duration { get; set; }
        public GenreType TypeOfGenre { get; set; }
        public bool IsMovie { get; set; }

        public StreamingContent()
        {

        }

        public StreamingContent(string name, double duration, GenreType genreType, bool isMovie)
        {
            Name = name;
            Duration = duration;
            TypeOfGenre = genreType;
            IsMovie = isMovie;
        }
    }
}
