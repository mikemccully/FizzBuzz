using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			FizzBuzz fb = new FizzBuzz();
			foreach (String value in fb)
			{
				Console.WriteLine(value);
			}
			Console.ReadLine();
		}
	}
}
