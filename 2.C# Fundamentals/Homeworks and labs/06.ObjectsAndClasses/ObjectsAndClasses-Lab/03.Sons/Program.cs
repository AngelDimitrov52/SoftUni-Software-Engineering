using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Sons
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> SongList = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] comand = Console.ReadLine().Split("_");
                string type = comand[0];
                string name = comand[1];
                string time = comand[2];

                Song pesen = new Song(type, name, time);

                SongList.Add(pesen);
            }

            string secondComand = Console.ReadLine();

            if (secondComand == "all")
            {
                foreach (Song pesen in SongList)
                {
                    Console.WriteLine(pesen.Name);
                }
            }
            else
            {
                List<Song> filterSong = SongList.Where(x => x.TypeList == secondComand).ToList();

                foreach (Song item in filterSong)
                {
                    Console.WriteLine(item.Name);
                }
            }

        }
    }
    class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
}
