using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.ViewModels
{
    public class SubCategoryandCategoryViewModel
    {
        // To get list of Category

        public IEnumerable<Category> CategoryList { get; set; }

        //For One Sub Category

        public SubCategory SubCategory { get; set; }

        //list of sub category based on selected category

        public List<string> SubCategoryList { get; set; }

        //string for status message

        public string StatusMessage { get; set; }
    }
}
