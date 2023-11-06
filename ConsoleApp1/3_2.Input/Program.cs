namespace _3_2.Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // {0} 은 하나씩 들어간다고 생각하면 됨
            //Console.WriteLine("Enter Your Name: ");
            //string name = Console.ReadLine();
            //string age = Console.ReadLine();
            //Console.WriteLine("Hello, {0}", name); // name을 반환(0번째 칸)
            //Console.WriteLine("Age, {1}", name, age);// age를 반환(1번째 칸)

            Console.WriteLine("Enter two Numbers: ");
            string input = Console.ReadLine(); // "10 20" 라는 문자열을 입력받는다.

            string[] numbers = input.Split(' ');    // 문자열을 공백으로 구분하여 배열로 만든다. {"10", "20"} 
            int num1 = int.Parse(numbers[0]);   // 첫 번째 값을 정수로 형변환
            int num2 = int.Parse(numbers[1]);   // 두 번째 값을 정수로 형변환

            int sum = num1 + num2; // 두 수의 합

            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, sum);


            //var 키워드: 변수의 자료형이 컴파일러에 의해 자동으로 결정된다.
            var num = 10;   //int 자료형
            var name = "jun";   //string 자료형
            var pi = 3.141592;  //double 자료형

            Console.WriteLine("result {0}, {1}, {2}", num, name, pi);

        }
    }
}