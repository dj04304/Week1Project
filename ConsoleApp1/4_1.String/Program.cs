namespace _4_1.String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 문자열
            string str1 = "Hello, World!";
            string str2 = new string('h', 5);

            string str3 = str1 + " " + str2;
            Console.WriteLine(str3);

            Console.WriteLine("-------------------------------------");
            //문자열 분할 (Split)
            string[] str4 = str1.Split(", "); //,와 띄어쓰기도 포함됨
            Console.WriteLine(str4[0]);
            Console.WriteLine(str4[1]);

            Console.WriteLine("-------------------------------------");

            //검색(IndexOf)   해당 단어의 위치를 검색
            int index = str1.IndexOf("World");
            Console.WriteLine("IndexOf: " + index); // 7이 나옴, 7번째 부터 World가 시작되기 때문

            Console.WriteLine("-------------------------------------");

            //교체(Replace)   지정한 단어를 뒤에오는 단어로 교체
            string newStr = str1.Replace("World", "Universe");
            Console.WriteLine("Replace: " + newStr);
            Console.WriteLine(str1);

            Console.WriteLine("-------------------------------------");

            //형변환
            string str5 = "123";
            int num = int.Parse(str5);
            num += 10;
            Console.WriteLine("int: " + num);

            num += 10;
            Console.WriteLine("string: " + num.ToString());

            Console.WriteLine("-------------------------------------");

            // 비교 (Compare)     같으면 0, 앞이 크면 1, 뒤가 크면 -1
            Console.WriteLine(str1 == str2); //false
            Console.WriteLine(string.Compare(str1, str2)); // -1, 소문자가 아스키코드로 대문자보다 크기 때문에 -1임


            Console.WriteLine("-------------------------------------");


            //포맷팅
            string name = "John";
            int age = 30;
            string message = string.Format("My name is {0}, and I'm {1} years old", name, age);

            Console.WriteLine("Fomating: " + message);

            message = $"My name is {name} and I'm {age} years old HELLO";

            Console.WriteLine("Formating2 :" + message);

        }
    }
}