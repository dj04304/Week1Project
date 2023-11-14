﻿using System.Security;

namespace _4_5Lamda
{
    internal class Program
    {
        //delegate

        delegate void MyDelegate(string message);

        static void Method1(string message)
        {
            Console.WriteLine("Method1: " + message);
        }

        static void Method2(string message)
        {
            Console.WriteLine("Method2: " + message);
        }

        static void Main(string[] args)
        {
            MyDelegate myDelegate = Method1;
            myDelegate += Method2; //Method1 과 Method2 연결

            myDelegate("Hello!"); // 둘을 한 번에 호출

        }
    }
}