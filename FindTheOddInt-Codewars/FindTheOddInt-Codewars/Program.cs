using System;
using System.Linq;

namespace FindTheOddInt_Codewars
{
    class Program
    {
        
        public static int find_it(int[] seq)
        {
            int count=0;
            var groups = seq.GroupBy(n => n);
            foreach (var group in groups)
            {
                if (group.Count() % 2 != 0)
                {
                    count = group.Key;
                }               
            }
            return count;
                
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}