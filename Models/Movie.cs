﻿using System.ComponentModel.DataAnnotations;

namespace TheATCMovieBlog.Models
{
    public class Movie
    {

        public Guid ID { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string? Overview { get; set; }
        public string? Genre { get; set; }

        public decimal Price { get; set; }

    }
}
