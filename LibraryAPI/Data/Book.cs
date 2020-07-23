﻿using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Data
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }
}
