using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace Interview.Example1
{
	public class StringReverse
	{
		
        delegate string StringDelegate(string s);

        static void Benchmark(string description, StringDelegate d, int times, string text)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int j = 0; j < times; j++)
            {
                d(text);
            }
            sw.Stop();
			
            Console.WriteLine("{0} Ticks {1} : called {2} times.", sw.ElapsedTicks, description, times);
        }
		
		
        public static string ReverseArray(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return (new string(array));
        }
		
       
		
		static void Main(string[] args)
        {

	        string text = "interview today";
	        Benchmark(String.Format("Array.Reverse (Length: {0})", text.Length), ReverseArray, 10, text);


        }
	}
}

