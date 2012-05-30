using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzTestProject
{
	[TestClass]
	public class FizzBuzzTest
	{
		/// <summary>
		///ProcessValue should return the string version of an integer that is
		///not divisible by 3 or 5. If an integer is divisible by 3, then the
		///default behavior is to return "Fizz". If an integer is divisible by
		///5 then the default behavior is to return "Buzz". If an integer is 
		///divisible by both 3 and 5, then the default behavior is to return
		///"FizzBuzz". The behavior can be overridden to return strings that
		///are defined in the constructor.
		///</summary>
		[TestMethod()]
		[DeploymentItem("FizzBuzz.exe")]
		public void ProcessValueTest()
		{
			int num; // The number to test.
			string expected; // The expected return value.
			string actual; // The actual return value.
			FizzBuzz_Accessor target;// The object to test on.

			target = new FizzBuzz_Accessor(); 
			// Test for a returned value not divisible by 3 or 5
			num = 1;
			expected = "1";
			actual = target.ProcessValue(num);
			Assert.AreEqual(expected, actual);

			// Test for a returned value divisible by 3
			num = 6;
			expected = "Fizz";
			actual = target.ProcessValue(num);
			Assert.AreEqual(expected, actual);

			// Test for a returned value divisible by 5
			num = 20;
			expected = "Buzz";
			actual = target.ProcessValue(num);
			Assert.AreEqual(expected, actual);

			// Test for a returned value divisible by both 3 and 5
			num = 30;
			expected = "FizzBuzz";
			actual = target.ProcessValue(num);
			Assert.AreEqual(expected, actual);

			// Test the overridden tokens for fizz and buzz
			target = new FizzBuzz_Accessor( "Honk", "Tonk" );
			num = 30;
			expected = "HonkTonk";
			actual = target.ProcessValue(num);
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///IsDivisibleBy5 should return a boolean false for an integer that is
		///not divisible by 5 and a boolean true for an integer that is 
		///divisible by 5
		///</summary>
		[TestMethod()]
		[DeploymentItem("FizzBuzz.exe")]
		public void IsDivisibleBy5Test()
		{
			int num; // The number to test.
			bool expected; // The expected return value.
			bool actual; // The actual return value.
			FizzBuzz_Accessor target;// The object to test on.

			target = new FizzBuzz_Accessor();
			// Test a case that is not divisible by 5
			num = 3; 
			expected = false; 
			actual = target.IsDivisibleBy5(num);
			Assert.AreEqual(expected, actual);

			// Test a case that is divisible by 5
			num = 5;
			expected = true;
			actual = target.IsDivisibleBy5(num);
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///IsDivisibleBy3 should return a boolean false for an integer that is 
		///not divisible by 3 and a boolean true for an integer that is 
		///divisible by 3.
		///</summary>
		[TestMethod()]
		[DeploymentItem("FizzBuzz.exe")]
		public void IsDivisibleBy3Test()
		{
			int num; // The number to test.
			bool expected; // The expected return value.
			bool actual; // The actual return value.
			FizzBuzz_Accessor target;// The object to test on.

			target = new FizzBuzz_Accessor();
			// Test a case that is divisible by 3
			num = 3;
			expected = true;
			actual = target.IsDivisibleBy3(num);
			Assert.AreEqual(expected, actual);

			// Test a case that is not divisible by 3
			num = 5;
			expected = false;
			actual = target.IsDivisibleBy3(num);
			Assert.AreEqual(expected, actual);
		}
	}
}
