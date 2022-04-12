﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Books_API.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
    }
}
