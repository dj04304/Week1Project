namespace _5.Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //string[] arr = input.Split(' ');

            //string name = arr[0];
            //int age = int.Parse(arr[1]);

            //string message = $"Hello My Name is {name} and I'm {age} Years Old";

            //Console.WriteLine(message);

            //string input = Console.ReadLine();
            //string[] arr = input.Split(' ');

            //int num1 = int.Parse(arr[0]);
            //int num2 = int.Parse(arr[1]);

            //int result1 = num1 + num2;
            //int result2 = num1 - num2;
            //int result3 = num1 * num2;
            //int result4 = num1 / num2;
            //int result5 = num1 % num2;

            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);
            //Console.WriteLine(result4);
            //Console.WriteLine(result5);


            //celsius: 섭씨, fahrenheit: 화씨
            //string input = Console.ReadLine();

            //int celsius = int.Parse(input);

            //int fahrenheit = (celsius * 9 / 5) + 32;

            //Console.WriteLine("화씨: " + fahrenheit + "°F");

            //bmi 계산기

            Console.WriteLine("키와 몸무게를 순서대로 입력해주세요");
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');

            float height = float.Parse(arr[0]);
            float weight = float.Parse(arr[1]);

            float bmi = weight / ( ( height / 100 ) * ( height / 100 ) );


            string result = "정상";

            if ( bmi > 25.0f)
            {
                result = "비만";
            }else if(bmi < 23.0f && bmi > 24.9f)
            {
                result = "과체중";
            }else if (bmi > 18.5f &&  bmi < 22.9f)
            {
                result = "정상";
            }else
            {
                result = "저체중";
            }

            string message = $"사용자님의 bmi지수는 {bmi} 이고, {result} 입니다.";

            Console.WriteLine(message);
        }
    }
}