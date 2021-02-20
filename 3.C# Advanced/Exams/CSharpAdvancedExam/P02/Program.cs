using System;
using System.Collections.Generic;
using System.Linq;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> comandsOneTwo = new Queue<string>(Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries));

            int coutFirstShip = 0;
            int coutSecondShip = 0;


            char[,] martrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] elements = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    martrix[row, col] = elements[col];
                    if (elements[col] == '<')
                    {
                        coutFirstShip++;
                    }
                    else if (elements[col] == '>')
                    {
                        coutSecondShip++;
                    }
                }
            }
            int coutShips = 0;

            while (comandsOneTwo.Count > 0)
            {
                string firstComand = comandsOneTwo.Dequeue();
                int[] indexOneTwo = firstComand.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                int myrow = indexOneTwo[0];
                int mycol = indexOneTwo[1];

                if (myrow > n-1 || myrow <0 || mycol > n-1 || mycol <0)
                {
                    continue;
                }

                if (martrix[myrow,mycol] == '<')
                {
                    coutFirstShip--;
                    martrix[myrow, mycol] = 'X';
                    coutShips++;
                }
                if (martrix[myrow, mycol] == '>')
                {
                    coutSecondShip--;
                    martrix[myrow, mycol] = 'X';
                    coutShips++;
                }

                if (martrix[myrow, mycol] == '#')
                {
                    if (myrow +1 > 0 && myrow +1 < n)
                    {
                        if (martrix[myrow + 1, mycol] == '<')
                        {
                            coutFirstShip--;
                            martrix[myrow, mycol] = 'X';
                            coutShips++;
                        }
                        if (martrix[myrow + 1, mycol] == '>')
                        {
                            coutSecondShip--;
                            martrix[myrow, mycol] = 'X';
                            coutShips++;
                        }
                    }
                    if (myrow - 1 > 0 && myrow - 1 < n)
                    {
                        if (martrix[myrow - 1, mycol] == '<')
                        {
                            coutFirstShip--;
                            martrix[myrow, mycol] = 'X';
                            coutShips++;
                        }
                        if (martrix[myrow - 1, mycol] == '>')
                        {
                            coutSecondShip--;
                            martrix[myrow, mycol] = 'X';
                            coutShips++;
                        }
                    }
                    if (mycol +1 > 0 && mycol + 1 < n)
                    {
                        if (martrix[myrow , mycol + 1] == '<')
                        {
                            coutFirstShip--;
                            martrix[myrow, mycol] = 'X';
                            coutShips++;
                        }
                        if (martrix[myrow , mycol + 1] == '>')
                        {
                            coutSecondShip--;
                            martrix[myrow, mycol] = 'X';
                            coutShips++;
                        }
                    }
                    if (mycol - 1 > 0 && mycol - 1 < n)
                    {
                        if (martrix[myrow, mycol - 1] == '<')
                        {
                            coutFirstShip--;
                            martrix[myrow, mycol] = 'X';
                            coutShips++;
                        }
                        if (martrix[myrow, mycol - 1] == '>')
                        {
                            coutSecondShip--;
                            martrix[myrow, mycol] = 'X';
                            coutShips++;
                        }
                    }
                    if (myrow + 1 > 0 && myrow + 1 < n && mycol + 1 > 0 && mycol + 1 < n)
                    {
                        if (martrix[myrow+1, mycol + 1] == '<')
                        {
                            coutFirstShip--;
                            martrix[myrow, mycol] = 'X';
                            coutShips++;
                        }
                        if (martrix[myrow+1, mycol + 1] == '>')
                        {
                            coutSecondShip--;
                            martrix[myrow, mycol] = 'X';
                            coutShips++;
                        }
                    }
                    if (myrow - 1 > 0 && myrow - 1 < n && mycol + 1 > 0 && mycol + 1 < n)
                    {
                        if (martrix[myrow - 1, mycol + 1] == '<')
                        {
                            coutFirstShip--;
                            martrix[myrow, mycol] = 'X';
                            coutShips++;
                        }
                        if (martrix[myrow - 1, mycol + 1] == '>')
                        {
                            coutSecondShip--;
                            martrix[myrow, mycol] = 'X';
                            coutShips++;
                        }
                    }
                    if (myrow - 1 > 0 && myrow - 1 < n && mycol - 1 > 0 && mycol - 1 < n)
                    {
                        if (martrix[myrow - 1, mycol - 1] == '<')
                        {
                            coutFirstShip--;
                            martrix[myrow, mycol] = 'X';
                            coutShips++;
                        }
                        if (martrix[myrow - 1, mycol - 1] == '>')
                        {
                            coutSecondShip--;
                            martrix[myrow, mycol] = 'X';
                            coutShips++;
                        }
                    }
                    if (myrow + 1 > 0 && myrow + 1 < n && mycol - 1 > 0 && mycol - 1 < n)
                    {
                        if (martrix[myrow + 1, mycol - 1] == '<')
                        {
                            coutFirstShip--;
                            martrix[myrow, mycol] = 'X';
                            coutShips++;
                        }
                        if (martrix[myrow + 1, mycol - 1] == '>')
                        {
                            coutSecondShip--;
                            martrix[myrow, mycol] = 'X';
                            coutShips++;
                        }
                    }
                }

                if (coutSecondShip == 0)
                {
                    Console.WriteLine($"Player One has won the game! {coutShips} ships have been sunk in the battle.");
                    return;
                }
                if (coutFirstShip == 0)
                {
                    Console.WriteLine($"Player Two has won the game! {coutShips} ships have been sunk in the battle.");
                    return;
                }
            }
            Console.WriteLine($"It's a draw! Player One has {coutFirstShip} ships left. Player Two has {coutSecondShip} ships left.");



        }
    }
}
