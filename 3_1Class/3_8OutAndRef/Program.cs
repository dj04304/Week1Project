namespace _3_8OutAndRef
{
    internal class Program
    {
        // out 키워드 사용 예시
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            // 메서드 내에서 out으로 받은 변수들을 초기화 하지 않아서 오류가 남
            // 즉, out을 제공한 메서드에서는 무조건 값이 바뀌어서 나가야 한다.

            quotient = a / b;
            remainder = a % b;

        }

        // ref 키워드 사용 예시
        static void Swap(ref int a, ref int b)
        {

            //ref는 사용할지 안할지 선택할 수 있다.
            //즉, 값을 기입하지 않아도 오류가 나지 않는다.

            // 대표적인 스왑코드
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int quotient, remainder; // Divide 함수에서 날린 어떠한 값이 들어있다.
            Divide(7, 3, out quotient, out remainder);
            Console.WriteLine($"{quotient}, {remainder}");

            int x = 1, y = 2;
            Swap(ref x, ref y);
            Console.WriteLine($"{x}, {y}");
        }
    }
}