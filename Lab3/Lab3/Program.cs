using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Regex r = new Regex(@"\w+@\w+\.\w+");

			string[] input = File.ReadAllLines(@"source.txt");

			for (int i = 0; i < input.Length; i++)
			{
				if (r.IsMatch(input[i]))
					Console.WriteLine($"{input[i]} похож на e-mails");
				else
					Console.WriteLine(input[i]);
			}
		}
	}
}
