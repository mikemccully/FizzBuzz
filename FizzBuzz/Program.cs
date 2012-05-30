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
			int start = -32;
			int end = 1000;
			FizzBuzz fb = new FizzBuzz( start, end );
			Console.BufferHeight = fb.Size + 2;
			foreach (String value in fb)
			{
				Console.WriteLine(value);
			}
			Console.ReadLine();
		}
	}
}
