using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _3309___Term_Project___Jeopardy;
using System.Collections.Generic;
using System.Linq;

namespace Jeopardy___Unit_Testing
{
    [TestClass]
    public class CategoryListTest
    {
        [TestMethod]
        public void TestCategoryList() //test default empty constructor
        {
            //test - initiated CategoryList object
            CategoryList categoryList = new CategoryList();
            Assert.IsNotNull(categoryList);
            Assert.AreEqual(0, categoryList.Categories.Count);

            //test - if data in the object (List<Category>) changes
            List<Question> questionList1 = new List<Question>();
            String music = "music";
            Category category1 = new Category(music, questionList1); //Category object to be added
            categoryList.Categories.Add(category1); //not using AddCategory() in CategoryList class
            Assert.AreEqual(1, categoryList.Categories.Count);

            //making sure CategoryList contains the exact same Category object that was just added
            bool containCategory1 = categoryList.Categories.Contains(category1);
            Assert.AreEqual(true, containCategory1);

            //test - if data in the object changes (part 2)
            List<Question> questionList2 = new List<Question>();
            String animal = "animal";
            Category category2 = new Category(animal, questionList2); //Category object to be added
            categoryList.Categories.Add(category2); //not using AddCategory() in CategoryList class
            Assert.AreEqual(2, categoryList.Categories.Count);

            //making sure CategoryList contains the exact same Category object that was just added (part 2)
            bool containCategory2 = categoryList.Categories.Contains(category2);
            Assert.AreEqual(true, containCategory2);

            //test if the list of categories doesn't contain Category object that isn't added 
            List<Question> questionList3 = new List<Question>();
            String temple = "temple";
            Category category3 = new Category(temple, questionList3);
            bool containCategory3 = categoryList.Categories.Contains(category3);
            Assert.AreEqual(false, containCategory3); //didn't add category3, just created

            //more testing...
            CategoryList categoryList2 = new CategoryList();
            Assert.IsNotNull(categoryList2);
            Assert.AreEqual(0, categoryList2.Categories.Count);
            Assert.AreEqual(false, categoryList2.Categories.Contains(category1));
            Assert.AreEqual(false, categoryList2.Categories.Contains(category2));
            Assert.AreEqual(false, categoryList2.Categories.Contains(category3));

            categoryList2.Categories.Add(category1); //not using AddCategory(), will test it later
            Assert.AreEqual(true, categoryList2.Categories.Contains(category1));
            Assert.AreEqual(1, categoryList2.Categories.Count);

            categoryList2.Categories.Add(category2);
            Assert.AreEqual(true, categoryList2.Categories.Contains(category2));
            Assert.AreEqual(2, categoryList2.Categories.Count);

            categoryList2.Categories.Add(category3);
            Assert.AreEqual(3, categoryList2.Categories.Count);
            Assert.AreEqual(true, categoryList2.Categories.Contains(category3));

            categoryList2.Categories.Clear();
            Assert.AreEqual(0, categoryList2.Categories.Count);
        }

        [TestMethod]
        public void TestAddCategory()
        {
            CategoryList categoryList = new CategoryList();
            Category category1 = new Category("Music", new List<Question>());
            Category category2 = new Category("Animal", new List<Question>());
            Category category3 = new Category("Temple", new List<Question>());

            //before change
            Assert.AreEqual(0, categoryList.Categories.Count);
            Assert.AreEqual(false, categoryList.Categories.Contains(category1));

            categoryList.AddCategory(category1);
            //after change (following codes may be redundant, but just to be safe)
            Assert.AreEqual(1, categoryList.Categories.Count);
            Assert.AreEqual(true, categoryList.Categories.Contains(category1));
            Assert.AreSame(category1, categoryList.Categories.ElementAt(0));
            Assert.AreEqual(category1.CategoryName, categoryList.Categories.ElementAt(0).CategoryName);
            Assert.AreEqual("Music", categoryList.Categories.ElementAt(0).CategoryName);

            //before 2nd change
            Assert.AreEqual(false, categoryList.Categories.Contains(category2));

            categoryList.AddCategory(category2);
            //after 2nd change (following codes may be redundant, but just to be safe)
            Assert.AreEqual(2, categoryList.Categories.Count);
            Assert.AreEqual(true, categoryList.Categories.Contains(category2));
            Assert.AreSame(category2, categoryList.Categories.ElementAt(1));
            Assert.AreEqual(category2.CategoryName, categoryList.Categories.ElementAt(1).CategoryName);
            Assert.AreEqual("Animal", categoryList.Categories.ElementAt(1).CategoryName);

            //before 3rd change
            Assert.AreEqual(false, categoryList.Categories.Contains(category3));

            categoryList.AddCategory(category3);
            //after 3rd change (following codes may be redundant, but just to be safe)
            Assert.AreEqual(3, categoryList.Categories.Count);
            Assert.AreEqual(true, categoryList.Categories.Contains(category3));
            Assert.AreSame(category3, categoryList.Categories.ElementAt(2));
            Assert.AreEqual(category3.CategoryName, categoryList.Categories.ElementAt(2).CategoryName);
            Assert.AreEqual("Temple", categoryList.Categories.ElementAt(2).CategoryName);

            //test -  clearing the list
            categoryList.Categories.Clear();
            Assert.AreNotEqual(3, categoryList.Categories.Count);
            Assert.AreEqual(0, categoryList.Categories.Count);
            Assert.AreEqual(false, categoryList.Categories.Contains(category1));
            Assert.AreEqual(false, categoryList.Categories.Contains(category2));
            Assert.AreEqual(false, categoryList.Categories.Contains(category3));
        }

        [TestMethod]
        public void TestRemoveCategory()
        {
            CategoryList categoryList = new CategoryList();
            Category category1 = new Category("Music", new List<Question>());
            Category category2 = new Category("Animal", new List<Question>());
            Category category3 = new Category("Temple", new List<Question>());
            categoryList.AddCategory(category1);
            categoryList.AddCategory(category2);
            categoryList.AddCategory(category3);

            //before removing
            Assert.AreEqual(3, categoryList.Categories.Count);
            Assert.AreEqual(true, categoryList.Categories.Contains(category1));
            Assert.AreEqual(true, categoryList.Categories.Contains(category2));
            Assert.AreEqual(true, categoryList.Categories.Contains(category3));

            //after removing 1st category object
            categoryList.RemoveCategory(category1);
            Assert.AreEqual(2, categoryList.Categories.Count);
            Assert.AreEqual(false, categoryList.Categories.Contains(category1));
            Assert.AreEqual(true, categoryList.Categories.Contains(category2));
            Assert.AreEqual(true, categoryList.Categories.Contains(category3));

            //after removing 2nd category object
            categoryList.RemoveCategory(category2);
            Assert.AreEqual(1, categoryList.Categories.Count);
            Assert.AreEqual(false, categoryList.Categories.Contains(category1));
            Assert.AreEqual(false, categoryList.Categories.Contains(category2));
            Assert.AreEqual(true, categoryList.Categories.Contains(category3));

            //after removing 3rd category object
            categoryList.RemoveCategory(category3);
            Assert.AreEqual(0, categoryList.Categories.Count);
            Assert.AreEqual(false, categoryList.Categories.Contains(category1));
            Assert.AreEqual(false, categoryList.Categories.Contains(category2));
            Assert.AreEqual(false, categoryList.Categories.Contains(category3));

            //test - try to remove a category object that doesn't exist in the list
            //1st, add categor1 and category2 back
            categoryList.AddCategory(category1);
            categoryList.AddCategory(category2);
            Assert.AreEqual(2, categoryList.Categories.Count);
            Assert.AreEqual(false, categoryList.Categories.Contains(category3));
            //then, remove category3 from the list (category3 is not in the list)
            categoryList.RemoveCategory(category3);
            Assert.AreNotEqual(1, categoryList.Categories.Count);
            Assert.AreEqual(2, categoryList.Categories.Count);
            Assert.AreEqual(true, categoryList.Categories.Contains(category1));
            Assert.AreEqual(true, categoryList.Categories.Contains(category2));
        }

        [TestMethod]
        public void TestFindCategory()
        {
            CategoryList categoryList = new CategoryList();
            Category category1 = new Category("Music", new List<Question>());
            Category category2 = new Category("Animal", new List<Question>());
            categoryList.AddCategory(category1);
            categoryList.AddCategory(category2);
            //categoryList.AddCategory(category3);

            //test 1
            Category result = categoryList.FindCategory("Music");
            Assert.AreSame(category1, result);
            Assert.AreEqual(category1.CategoryName, result.CategoryName);
            Assert.AreEqual("Music", result.CategoryName);

            //test 2
            result = categoryList.FindCategory("Animal");
            Assert.AreNotSame(category1, result); //not previous category that was searched for
            Assert.AreSame(category2, result);
            Assert.AreEqual(category2.CategoryName, result.CategoryName);
            Assert.AreEqual("Animal", result.CategoryName);

            //test - find category that isn't in the list
            result = categoryList.FindCategory("Temple");
            Assert.AreNotSame(category2, result); //not previous category that was searched for
            Assert.AreEqual(null, result);

            //test - find category that isn't in the list (part 2)
            result = categoryList.FindCategory("Sport");
            Assert.AreEqual(null, result);
        }
    }
}
