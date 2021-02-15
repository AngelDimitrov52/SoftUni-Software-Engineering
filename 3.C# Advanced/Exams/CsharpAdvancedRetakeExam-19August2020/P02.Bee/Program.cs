    using System;

    namespace P02.Bee
    {
        class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());

                char[,] teritori = new char[n, n];
                int beeRow = 0;
                int beeCol = 0;

                for (int row = 0; row < teritori.GetLongLength(0); row++)
                {
                    string elements = Console.ReadLine();

                    for (int col = 0; col < teritori.GetLongLength(1); col++)
                    {
                        teritori[row, col] = elements[col];
                        if (elements[col] == 'B')
                        {
                            beeRow = row;
                            beeCol = col;
                        }
                    }
                }
                int pollinateFlowers = 0;
                string comand;
                while ((comand = Console.ReadLine()) != "End")
                {
                    teritori[beeRow, beeCol] = '.';

                    beeRow = MoveRow(beeRow, comand);
                    beeCol = MoveCol(beeCol, comand);

                    bool isValid = IsVAlidIndex(beeCol, beeRow , n);
                    if (!isValid)
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }

                    if (teritori[beeRow, beeCol] == 'f')
                    {
                        pollinateFlowers++;
                    }
                    else if (teritori[beeRow, beeCol] == 'O')
                    {
                        teritori[beeRow, beeCol] = '.';
                        beeRow = MoveRow(beeRow, comand);
                        beeCol = MoveCol(beeCol, comand);

                         isValid = IsVAlidIndex(beeCol, beeRow, n);
                        if (!isValid)
                        {
                            Console.WriteLine("The bee got lost!");
                            break;
                        }

                        if (teritori[beeRow, beeCol] == 'f')
                        {
                            pollinateFlowers++;
                        }

                    }
                    teritori[beeRow, beeCol] = 'B';

                }

                if (pollinateFlowers >= 5)
                {
                    Console.WriteLine($"Great job, the bee managed to pollinate {pollinateFlowers} flowers!");
                }
                else
                {
                    Console.WriteLine($"The bee couldn't pollinate the flowers, she needed" +
                        $" {5 - pollinateFlowers} flowers more");
                }
                for (int row = 0; row < teritori.GetLongLength(0); row++)
                {
                    for (int col = 0; col < teritori.GetLongLength(1); col++)
                    {
                        Console.Write(teritori[row, col]);
                    }
                    Console.WriteLine();
                }

            }

            private static bool IsVAlidIndex(int beeCol, int beeRow , int n)
            {
                if (beeCol < 0 || beeRow > n - 1 || beeCol < 0 || beeCol > n - 1)
                {  
                    return false;
                }
                return true;
            }

            private static int MoveCol(int beeCol, string comand)
            {
                if (comand == "left")
                {
                    beeCol--;
                }
                else if (comand == "right")
                {
                    beeCol++;
                }
                return beeCol;
            }

            private static int MoveRow(int beeRow, string comand)
            {
                if (comand == "up")
                {
                    beeRow--;
                }
                else if (comand == "down")
                {
                    beeRow++;
                }
                return beeRow;
            }


        }
    }
