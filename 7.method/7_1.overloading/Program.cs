namespace _7_1.overloading
{
    internal class Program
    {
        // 오버로딩 매개변수의 자료형, 개수가 다르다면 같은 함수의 이름을 사용할 수 있다.
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        static float AddNumbers(float a, float b)
        {
            return a + b;
        }

        static int AddNumbers(int a, int b , int c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            int sum1 = AddNumbers(10, 20);
            float sum2 = AddNumbers(10.5f, 21.5f); ;
            int sum3 = AddNumbers(10, 20, 30);

           
        }
    }
}