using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab4b
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Regex r = new Regex(@"^(?<city>[А-Яа-я\-\s]*):\s+(широта)?\s*(?<latitude>\d+[\.]*\d*)([,\s]+)(долгота)?\s*(?<longitude>\d+[\.]*\d*)");

			string[] input = File.ReadAllLines(@"source.txt");

			for (int i = 0; i < input.Length; i++)
			{
				Match m = r.Match(input[i]);
				if (m.Success)
					Console.WriteLine($"{input[i]} - это объект на карте: {m.Groups["city"]}: широта {m.Groups["latitude"]}, долгота {m.Groups["longitude"]}");
				else
					Console.WriteLine($"\"{input[i]}\" не найено");
			}
		}
	}
}
