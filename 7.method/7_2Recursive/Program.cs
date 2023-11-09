namespace _7_2Recursive
{
    internal class Program
    {
        //재귀 호출 기초
        static void CountDown(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Done");
            }
            else
            {
                Console.WriteLine(n);
                CountDown(n - 1);  // 자기 자신을 호출
            }
        }
        static void Main(string[] args)
        {
            // 메서드 호출
            CountDown(5);
            
        }
    }
}