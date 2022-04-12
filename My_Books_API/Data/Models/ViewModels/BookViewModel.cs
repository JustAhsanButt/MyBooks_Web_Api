using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Books_API.Data.Models.ViewModels
{
    public class BookViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
    }
}
