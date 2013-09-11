using System;
using NUnit.Framework;
using Interview.Example0;

namespace UnitTest
{
	[TestFixture()]
	public class ReverseStringTest
	{
		[Test()]
		public void ReverseString ()
		{
			Console.WriteLine("original -->" + Interview.Example0.StringReverse.ReverseString("sta"));
			
		}
		
	}
}

