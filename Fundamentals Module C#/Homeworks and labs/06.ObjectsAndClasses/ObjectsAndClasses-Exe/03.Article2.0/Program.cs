using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<Articles> articlesList = new List<Articles>();

            for (int i = 0; i < n; i++)
            {
                string[] comandArgs = Console.ReadLine().Split(", ");
                string title = comandArgs[0];
                string content = comandArgs[1];
                string author = comandArgs[2];

                Articles objects = new Articles(title,content,author);

                articlesList.Add(objects);
            }
           string comand2 = Console.ReadLine();

            if (comand2 == "title")
            {
               articlesList = articlesList.OrderBy(x => x.Title).ToList();
            }
            else if (comand2 == "content")
            {
                articlesList= articlesList.OrderBy(x => x.Content).ToList();
            }
            else if (comand2 == "author")
            {
                articlesList= articlesList.OrderBy(x => x.Author).ToList();
            }

            foreach (Articles item in articlesList)
            {
                Console.WriteLine($"{ item.Title} - { item.Content}: { item.Author}");
            }


        }
    }
   
    class Articles
    {
        public Articles(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        



    }
}
