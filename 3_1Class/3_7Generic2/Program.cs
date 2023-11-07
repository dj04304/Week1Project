﻿namespace _3_7Generic2
{
    internal class Program
    {
        class Pair<T1, T2>
        {
            public T1 First { get; set; }
            public T2 Second { get; set; }

            public Pair(T1 first, T2 second)
            {
                First = first;
                Second = second;
            }

            public void Display()
            {
                Console.WriteLine($"First: {First}, Second: {Second}");
            }
        }
        static void Main(string[] args)
        {
            Pair<int, string> pair1 = new Pair<int, string>(1, "One");
            pair1.Display();

            Pair<double, bool> pair2 = new Pair<double, bool>(3.14, true);
            pair2.Display();
        }
    }
}