using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            Music music = new Music("Angel", "Colture", 10, 96);
            File file = new File("Angel", 10, 96);

            StreamProgressInfo stream = new StreamProgressInfo();
           

            Console.WriteLine(stream.CalculateCurrentPercent(music));
            Console.WriteLine(stream.CalculateCurrentPercent(file));
        }
    }
}
