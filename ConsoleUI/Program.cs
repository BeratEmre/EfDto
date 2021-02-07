using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            categoryManager.Add(new Category { CategoryName="NoteBooks"});
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine($"{category.CategoryName}");
            }
            
            Console.WriteLine("*****************");

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName+" / "+ product.CategoryName + " / "+ product.UnitsInStock);
            }

            
        }
    }
}
