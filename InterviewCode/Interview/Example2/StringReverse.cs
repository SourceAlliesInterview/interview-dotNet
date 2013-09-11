using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace Interview.Example2
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
		
        public static string StringOfLength(int length)
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))));
            }
            return sb.ToString();
        }		
		
		static void Main(string[] args)
        {

            int[] lengths = new int[] {1,10,15,25,50,75,100};

            foreach (int l in lengths)
            {
                int iterations = 10000;
                string text = StringOfLength(l);
                Benchmark(String.Format("Array.Reverse (Length: {0})", l), ReverseArray, iterations, text);

                Console.WriteLine();    
            }

        }
	}
}

