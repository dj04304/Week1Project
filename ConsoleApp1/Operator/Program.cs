namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 산술 연산자. 나머지(%)는 나누는 수를 무한히 빼고 남은 수를 말함
            Console.WriteLine("산술 연산자");
            int num1 = 20;
            int num2 = 10;

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 % num2);

            Console.WriteLine(); // 빈 줄 출력

            // 관계 연산자.
            Console.WriteLine("관계 연산자");

            Console.WriteLine(num1 == num2);
            Console.WriteLine(num1 != num2);
            Console.WriteLine(num1 > num2);
            Console.WriteLine(num1 < num2);
            Console.WriteLine(num1 >= num2);
            Console.WriteLine(num1 <= num2);

            Console.WriteLine(); // 빈 줄 출력

            Console.WriteLine("관계 연산자");

            int num3 = 15;
            // 0 <= num3 <= 20
            Console.WriteLine(0 <= num3 && num3 <= 20); //0 과 20 사이에 포함되면
            Console.WriteLine(0 > num3 || num3 > 20); // 0과 20사이에 포함되지 않으면

            Console.WriteLine( !( 0 <= num3 && num3 <= 20 ) ); //0 과 20 사이에 포함되지 않으면

            //비트 연산자.

            int a = 0b1100;    // 12 (2진수)
            int b = 0b1010;    // 10 (2진수)

            int and = a & b;    // 같은 수를 반환, 다를 때 0    (값: 1000  (8))
            int or = a | b;     // 다른 수를 반환, 같을 때 그 값을 반환   (값: 1110  (14)) 
            int xor = a ^ b;    // 두 값이 서로 다를 때 1을 반환   (값: 0110 (6))

            int c = 0b1011;  // 11 (2진수)
            int leftShift = c << 2; // 비트를 왼쪽으로 2칸 이동   (값: 101100 (44))
            int rightShift = c << 1; // 비트를 오른쪽으로 1칸 이동, 뒤 숫자는 날아감 (값: 0101 (5))

        }
    }
}