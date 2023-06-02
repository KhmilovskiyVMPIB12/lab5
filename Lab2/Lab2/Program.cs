using System;
using System.Text.RegularExpressions;

namespace Lab2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Regex r = new Regex(@"\w{5,}");
			string s = "";
			while(!r.IsMatch(s))
			{
                Console.Write("введите не менее 5 алфавитно-цифровых символов -> ");
                s = Console.ReadLine();
				if (!r.IsMatch(s))
                    Console.Write("условие не соблюдено, снова ");
            }
            Console.WriteLine($"Введённое значение {s} соответствует условию");
        }
	}
}
