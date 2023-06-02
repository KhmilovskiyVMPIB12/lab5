using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab4a
{
	internal class Program
	{
		static void Main(string[] args)
		{
		Regex r = new Regex(@"(ул.)?\s*(?<street>[A-Яа-яЁё\s]+)[,]*\s+(д.)?\s*(?<building>\d+(?:[/]*)\d*)");

			string[] input = File.ReadAllLines(@"source.txt");

			for (int i = 0; i < input.Length; i++)
			{
				Match m = r.Match(input[i]);
				if (m.Success)
					Console.WriteLine($"{input[i]} - это адрес: улица \"{m.Groups["street"]}\", дом № {m.Groups["building"]}");
				else
					Console.WriteLine($"\"{input[i]}\" не похоже на адрес");
			}
		}
	}
}
