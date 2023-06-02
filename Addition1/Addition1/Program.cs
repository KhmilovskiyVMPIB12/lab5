using System;
using System.Text.RegularExpressions;

namespace Addition1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string DecimalSeparator = 0.0m.ToString().Replace("0", "");
			string t = "Добро пожаловать в наш магазин, вот наши цены: 1 кг. яблоки - 90 руб., 2 кг. апельсины - 130 руб. Также в ассортименте орехи в следующей фасовке: 0.5 кг. миндаль - 500 руб.";
            Console.WriteLine(t);

			Regex r = new Regex(@"(?<weight>\d+[\.,]*\d*)\s+кг\.\s+(?<product>[\w\s]+)\s*-\s*(?<cost>\d+[\.,]*\d*)\s+руб\.");
			Match m = r.Match(t);
			while (m.Success)
			{
				float cost = float.Parse(m.Groups["cost"].Value);
				float weight = float.Parse(m.Groups["weight"].Value.Replace(".", DecimalSeparator));
                Console.WriteLine($"{m.Groups["product"]} - {cost / weight}");
                m = m.NextMatch();
			}
        }
	}
}
