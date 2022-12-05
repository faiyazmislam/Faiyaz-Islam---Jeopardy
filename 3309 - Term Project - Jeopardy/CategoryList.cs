using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309___Term_Project___Jeopardy
{
    public class CategoryList
    {
        public List<Category> Categories { get; set; }

        public CategoryList()
        {
            this.Categories = new List<Category>();
        }

        public void AddCategory(Category category)
        {
            Categories.Add(category);
        }

        public void RemoveCategory(Category category)
        {
            Categories.Remove(category);
        }

        public Category FindCategory(String choosenCategory)
        {
            foreach (Category category in Categories)
            {
                if (choosenCategory.Equals(category.CategoryName)) return category;
            }
            return null;
        }

        public Question GetQuestion(Category chosenCategory, int point) {

            if (Categories.Contains(chosenCategory))
            {
                return chosenCategory.FindQuestion(point);
            }


            return null;        
        }
    }

}
