using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
	/// <summary>
	/// This class will provide the ability to iterate through a set of 
	/// numbers, from smallest to largest, replacing numbers that are 
	/// divisible by 3 with "Fizz" or a supplied token and numbers that are
	/// divisible by 5 with "Buzz" or a supplied token. Numbers that are 
	/// divisible by both 3 and 5 will be replaced with "FizzBuzz" or the 
	/// concatenated supplied tokens.
	/// </summary>
	class FizzBuzz : System.Collections.IEnumerable
	{
		private int _StartNum;
		private int _EndNum;
		private String _Denom3Token;
		private String _Denom5Token;

		public int StartNum
		{
			get { return this._StartNum; }
			set { this._StartNum = value; }
		}

		public int EndNum
		{
			get { return this._EndNum; }
			set { this._EndNum = value; }
		}

		public String Denom3Token
		{
			get { return this._Denom3Token; }
			set { this._Denom3Token = value; }
		}

		public String Denom5Token
		{
			get { return this._Denom5Token; }
			set { this._Denom5Token = value; }
		}

		public int Size
		{
			get { return EndNum - StartNum; }
		}

		/// <summary>
		/// Give a start and end value, and tokens for what should be returned 
		/// when a number is divisible by 3 and/or 5.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="end"></param>
		/// <param name="tokenFizz"></param>
		/// <param name="tokenBuzz"></param>
		public FizzBuzz( int start, int end, String tokenFizz, String tokenBuzz )
		{
			/*
			 * If the start is not less than the end, then we need to swap 
			 * the numbers.
			 */
			if (start > end)
			{
				int temp = start;
				start = end;
				end = temp;
			}
			this.StartNum = start;
			this.EndNum = end;
			this.Denom3Token = tokenFizz;
			this.Denom5Token = tokenBuzz;
		}

		/// <summary>
		/// Give a start and end value. The tokens "Fizz" and "Buzz" will be 
		/// used for values that are divisible by 3 and/or 5.
		/// </summary>
		/// <param name="start"></param>
		/// <param name="end"></param>
		public FizzBuzz( int start, int end )
			: this( start, end, "Fizz", "Buzz" )
		{
		}

		/// <summary>
		/// Values 0 through 100 will be used to iterate over. Provide tokens to use
		/// when the value is divisible by 3 and/or 5.
		/// </summary>
		/// <param name="tokenFizz"></param>
		/// <param name="tokenBuzz"></param>
		public FizzBuzz(String tokenFizz, String tokenBuzz)
			: this(1, 100, tokenFizz, tokenBuzz)
		{
		}

		/// <summary>
		/// Values 0 through 100 will be used. "Fizz" and "Buzz" will replace 
		/// values that are divisible by 3 and/or 5.
		/// </summary>
		public FizzBuzz() 
			: this(1, 100, "Fizz", "Buzz")
		{
		}

		/// <summary>
		/// This method gets called to iterate over the values.
		/// </summary>
		/// <returns></returns>
		public System.Collections.IEnumerator GetEnumerator()
		{
			for (int i = this.StartNum; i <= this.EndNum; i++)
			{
				yield return this.ProcessValue(i);
			}
		}

		/// <summary>
		/// Process an integer. Return a string representation of the integer
		/// if it is not divisible by 3 and/or 5, else return the appropriate
		/// token.
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		protected String ProcessValue( int num )
		{
			String value = num.ToString();
			if (this.IsDivisibleBy3(num))
			{
				value = this.Denom3Token;
			}
			if (this.IsDivisibleBy5(num))
			{
				value = this.Denom5Token;
			}
			if (this.IsDivisibleBy3(num) && this.IsDivisibleBy5(num))
			{
				value = this.Denom3Token + this.Denom5Token;
			}

			return value;
		}

		/// <summary>
		/// Return true if the integer is divisible by 3, else return false.
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		protected bool IsDivisibleBy3(int num)
		{
			return (num % 3) == 0;
		}

		/// <summary>
		/// Return true if the integer is divisible by 5, else return false.
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		protected bool IsDivisibleBy5(int num)
		{
			return (num % 5) == 0;
		}
	}
}
