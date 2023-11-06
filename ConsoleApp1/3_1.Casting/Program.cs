namespace _3_1.Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 형변환

            //명시적 형변환
            int num = 10;
            long num2 = (long)num;

            //암시적 형변환(자동으로 형변환이 됨)
            // byte ,shor, char와 같이 작은 타입은 int, long, float 와 같은 더 큰 데이터 타입으로 변환할 때는 명시하지 않아도 형변환이 가능하다.

            byte num3 = 10;
            int num4 = num3;

            // 정수형과 부동소수점형(float)간의 연산시에 연산 결과는 float으로 변환된다.
            int num5 = 10;
            float f1 = 3.14f;
            float result = num5 + f1;
        }
    }
}