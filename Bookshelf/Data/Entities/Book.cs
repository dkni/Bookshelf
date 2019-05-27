﻿using System.ComponentModel.DataAnnotations;

namespace Bookshelf.Data.Entities
{
    public class Book
    {
        [Key]
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
