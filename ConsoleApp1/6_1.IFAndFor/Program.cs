namespace _6_1.IFAndFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //홀수, 짝수 구분하기
            //Console.WriteLine("번호를 입력하세요");
            //int number = int.Parse( Console.ReadLine() );

            //// 0 아니면 1 이 나오는데 0이면 짝수, 1이면 홀수가 됨
            //if(number % 2 == 0)
            //{
            //    Console.WriteLine("짝수입니다.");
            //}
            //else
            //{
            //    Console.WriteLine("홀수입니다.");
            //}

            // 2) 등급 출력
            //int playerScore = 100;
            //string playerRank = "";

            //switch(playerScore / 10)
            //{
            //    case 10:
            //    case 9:
            //        Console.WriteLine("Diamond");
            //        break;
            //    case 8:
            //        Console.WriteLine("Platinum");
            //        break;
            //    case 7:
            //        Console.WriteLine("Gold");
            //        break;
            //    case 6:
            //        Console.WriteLine("Silver");
            //        break;
            //    default:
            //        Console.WriteLine("Bronze");
            //        break;
            //}

            //Console.WriteLine(playerRank);

            // 3) 로그인 프로그램
            //string id = "id";
            //string password = "pw";

            //Console.WriteLine("아이디를 입력하세요: ");
            //string inputId = Console.ReadLine();
            //Console.WriteLine("비밀번호를 입력하세요: ");
            //string inputPw = Console.ReadLine();

            //if (id == inputId && password == inputPw)
            //{
            //    Console.WriteLine("로그인 성공");
            //}
            //else
            //{
            //    Console.WriteLine("로그인 실패, 아이디를 확인해주세요");
            //}

            // 4) 알파벳 판별 프로그램

            Console.WriteLine("문자를 입력하세요: ");
            //맨 앞에있는 한 글자만 가져옴
            char input = Console.ReadLine()[0];

            //소문자 a보다 크고 z보다 작은 (a~z)
            if( ( input >= 'a' && input <= 'z' ) || (input >= 'A' && input <= 'Z') )
            {
                Console.WriteLine("알파벳입니다.");
            }
            else
            {
                Console.WriteLine("알파벳이 아닙니다.");
            }

        }
    }
}