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
			int end = 5489;
			FizzBuzz fb = new FizzBuzz( start, end );
			foreach (String value in fb)
			{
				Console.BufferHeight = ( end - start ) + 2;
				Console.WriteLine(value);
			}
			Console.ReadLine();
		}
	}
}
