using System;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] first = Console.ReadLine().Split(", ");

            Articles text = new Articles(first[0],first[1],first[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] comand = Console.ReadLine().Split(": ");

                string type = comand[0];
                string change = comand[1];

                if (type == "Edit")
                {
                    text.Edit(change);
                }
                else if (type == "ChangeAuthor")
                {
                    text.ChangeAuthor(change);
                }
                else if (type == "Rename")
                {
                    text.Rename(change);
                }



            }
            Console.WriteLine(text.ToString());



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

        public void Edit(string content)

        {
            Content = content;
        }
        public void ChangeAuthor(string auter)

        {
            Author = auter;
        }
        public void Rename(string title)

        {
            Title = title;
        }
        public override string ToString()
        {
            return $"{ Title} - { Content}: { Author}";

        }


    }
}
