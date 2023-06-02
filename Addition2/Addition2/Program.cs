using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Addition2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Regex r = new Regex(@"\b([fhtps]*:)?/{0,2}[wW]{0,3}\.*([a-zA-z0-9_][a-zA-z0-9_\-]*\.)*[a-zA-z0-9_][a-zA-z0-9_\-]+\.[a-zA-z]+\b");
			Regex r1 = new Regex(@"^(([a-zA-Z][0-9a-zA-Z+\-\.]*:)?/{0,2}[0-9a-zA-Z;/?:@&=+$\.\-_!~*'()%]+)?(#[0-9a-zA-Z;/?:@&=+$\.\-_!~*'()%]+)?");

			string[] input = File.ReadAllLines(@"source.txt");

			using (StreamWriter writer = new StreamWriter("result.txt", false))
			{
				for (int i = 0; i < input.Length; i++)
				{
					Match m = r.Match(input[i]);

					while (m.Success)
					{
						writer.WriteLine($"подходящее под шаблон значение {m.Value} расположено в позиции {m.Index} строки {i + 1}");
						m = m.NextMatch();
					}
				}
			}
		}
	}
}
