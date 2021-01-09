using System;

namespace _01.First
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiBiskvitkiZaDen = int.Parse(Console.ReadLine());
            int broiRabotnici = int.Parse(Console.ReadLine());
            int fbrikSused = int.Parse(Console.ReadLine());

            double nashiBiskvitki = 0;

            for (int i = 1; i <= 30; i++)
            {
                double broiBiskviti = broiBiskvitkiZaDen;
                if (i % 3 == 0)
                {
                    broiBiskviti = broiBiskvitkiZaDen * 0.75;
                }
                double mid = Math.Floor(broiRabotnici * broiBiskviti);
                nashiBiskvitki += mid;
            }
            nashiBiskvitki =Math.Abs(Math.Floor(nashiBiskvitki));

            double procent = 0.0;
            double razlika = 0.0;
            if (fbrikSused < nashiBiskvitki)
            {
                razlika =Math.Abs(nashiBiskvitki - fbrikSused);
                procent = Math.Abs((razlika * 1.0 / fbrikSused) * 100);

                Console.WriteLine($"You have produced {nashiBiskvitki} biscuits for the past month.");
                Console.WriteLine($"You produce {procent:f2} percent more biscuits.");
            }
            else if (nashiBiskvitki < fbrikSused)
            {
                razlika = Math.Abs(fbrikSused - nashiBiskvitki);
                procent =Math.Abs((razlika * 1.0 / fbrikSused) * 100);
                Console.WriteLine($"You have produced {nashiBiskvitki} biscuits for the past month.");
                Console.WriteLine($"You produce {procent:f2} percent less biscuits.");
            }
        }
    }
}
