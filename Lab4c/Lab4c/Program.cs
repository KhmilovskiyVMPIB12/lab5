using System;
using System.Text.RegularExpressions;

namespace Lab4c
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			string info;

			Regex r = new Regex(@"\b(?<f>[\w]{2,})\b\s*\b(?<i>[\w]{2,})\b\s*\b(?<o>[\w]*)\b\s*,\s*(?<age>[1-9]{1}\d+)\s*лет,\s*(г\.)?\s*(?<city>\S{2,})");
			
			while(true)
			{
				Console.Write("Введите данные пользователя, или пустую строку для выхода -> ");
				info = Console.ReadLine();
				if (info.Length == 0) break;

				Match match = r.Match(info);
				if (match.Success)
				{
					Console.WriteLine($"город: {match.Groups["city"]}");
					Console.WriteLine($"имя: {match.Groups["f"]} {match.Groups["i"]} {match.Groups["o"]}");
					Console.WriteLine($"возраст: {match.Groups["age"]}");
				}
				else
					Console.WriteLine("Не найдено");

			}
		}
	}
}
