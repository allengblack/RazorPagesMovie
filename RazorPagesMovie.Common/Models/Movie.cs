using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesMovie.Common.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
