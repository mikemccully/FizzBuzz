using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
	class FizzBuzz
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

		public FizzBuzz( int start, int end, String tokenFizz, String tokenBuzz )
		{
			this.StartNum = start;
			this.EndNum = end;
			this.Denom3Token = tokenFizz;
			this.Denom5Token = tokenBuzz;
		}

		public FizzBuzz( int start, int end )
			: this( start, end, "Fizz", "Buzz" )
		{
		}

		public FizzBuzz(String tokenFizz, String tokenBuzz)
			: this(1, 100, tokenFizz, tokenBuzz)
		{
		}

		public FizzBuzz() 
			: this(1, 100, "Fizz", "Buzz")
		{
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			for (int i = this.StartNum; i <= this.EndNum; i++)
			{
				yield return this.ProcessValue(i);
			}
		}

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

		protected bool IsDivisibleBy3(int num)
		{
			return (num % 3) == 0;
		}

		protected bool IsDivisibleBy5(int num)
		{
			return (num % 5) == 0;
		}
	}
}
