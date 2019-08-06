using System;
using System.Collections.Generic;
using System.Linq;

namespace RecursionExamples
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Category> Children { get; set; }
    }

    static class CategoryExtentions
    {
        public static IEnumerable<Category> Traverse(this Category cat)
        {
            var stack = new Stack<Category>();
            stack.Push(cat);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                yield return current;
                Console.WriteLine($"{current.Id} - {current.Name}");
                if (current.Children != null)
                {
                    foreach (var child in current.Children)
                    {
                        stack.Push(child);
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Category cat = new Category { Id = 1, Name = "First",
                Children = new Category[2] {
                    new Category { Id = 2, Name = "Second", Children = new Category[2] { new Category { Id = 4, Name = "Forth", Children = null },
                                                                       new Category { Id = 5, Name = "Fifth", Children = null } }.ToList() },
                    new Category { Id = 3, Name = "Third", Children = null }
                }.ToList()  };

            //CategoryTraverse(cat);
            //NonRecursiveTraverse(cat);
            cat.Traverse().ToList();

            Console.WriteLine("Hello World!");
        }

        static void CategoryTraverse(Category category)
        {
            Console.WriteLine($"{category.Id} - {category.Name}");
            category.Children?.ForEach(CategoryTraverse);
        }

        static void NonRecursiveTraverse(Category cat)
        {
            var stack = new Stack<Category>();
            stack.Push(cat);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                //yield return current;
                Console.WriteLine($"{current.Id} - {current.Name}");
                if (current.Children != null)
                {
                    foreach (var child in current.Children)
                    {
                        stack.Push(child);
                    }
                }
            }
        }
    }
}
