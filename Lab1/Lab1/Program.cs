using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Regex[] r = { new Regex(@"\b[a]{1}\b"), new Regex(@"\b[a]{6}\b"), new Regex(@"\b[a]{1}\W+[a]{2}\W+[a]{1}\b") };
			
			string[] input = File.ReadAllLines(@"source.txt");

			for (int i = 0; i < input.Length; i++)
			{
				Console.WriteLine(input[i]);
				for (int j = 0; j < r.Length; j++)
				{
					if (r[j].IsMatch(input[i]))
						Console.WriteLine($"\tсоответствует шаблону \"{r[j].ToString()}\"");
				}
			}
		}
	}
}
