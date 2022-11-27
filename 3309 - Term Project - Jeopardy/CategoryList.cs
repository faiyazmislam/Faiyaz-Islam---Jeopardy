using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309___Term_Project___Jeopardy
{
    internal class CategoryList
    {
        List<Category> categories;

        public CategoryList()
        {
            this.categories = new List<Category>();
        }

        public List<Category> Categories { get; set; }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Remove(Category category)
        {
            categories.Remove(category);
        }

        public Category FindCategory(String choosenCategory)
        {
            foreach (Category category in categories)
            {
                if (choosenCategory.Equals(category.CategoryName)) return category;
            }
            return null;
        }
    }
}
