using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class CMath {
        public int Add(int a, int b){
            return a + b;
        }

        public int Max(int a, int b){
            if (a > b)
                return a;
            return b;
        }
    }
}
