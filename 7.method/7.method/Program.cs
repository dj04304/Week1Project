namespace _7.method
{
    internal class Program
    {
        static void PrintLine()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }

        static void PrintLine2(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            // Method 기초
            PrintLine();
            PrintLine2(20);

            int result = Add(10, 20);
            Console.WriteLine(result);

        }
    }
}