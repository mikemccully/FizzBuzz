using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
	class FizzBuzz
	{
		private int StartNum;
		private int EndNum;

		public FizzBuzz()
		{
			this.StartNum = 1;
			this.EndNum = 100;
		}

		public System.Collections.IEnumerator GetEnumerator()
		{
			for (int i = this.StartNum; i <= this.EndNum; i++)
			{
				String value = i.ToString();
				yield return value;
			}
		}
	}
}
