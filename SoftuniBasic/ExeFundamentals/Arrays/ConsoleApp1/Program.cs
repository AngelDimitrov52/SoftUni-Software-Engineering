using System;

public class Program
{
	public static void Main()
	{


		string input = Console.ReadLine();

		string[] items = input.Split();

		double[] numbers = new double[items.Length];


		for (int i = 0; i < items.Length; i++)

		{

			numbers[i] = double.Parse(items[i]);

			Console.WriteLine(items[i] + " => " + Math.Round(numbers[i]));

		}


	}

}
