using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.ViewModels
{
    public class AllBookViewModel
    {
        public List<BookViewModel> BookViewModels { get; set; }
        public string ImagePath { get; set; }
        public int Id { get; set; }
    }
}
