namespace _6_3ForDeepen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) 가위 바위 보
            //string[] choices = { "가위", "바위", "보" };
            //string playerChoice = "";
            //string computerChoice = choices[new Random().Next(0, 3)]; // 0, 1, 2 중 랜덤으로 나옴

            //while (playerChoice != computerChoice)
            //{
            //    Console.Write("가위 바위 보 중 하나를 선택하세요: ");
            //    playerChoice = Console.ReadLine();

            //    if(playerChoice == computerChoice)
            //    {
            //        Console.WriteLine("비겼습니다.");
            //        Console.WriteLine("프로그램을 종료합니다.");
            //    }
            //    else if(
            //        (playerChoice == "가위" && computerChoice == "보") ||
            //        (playerChoice == "바위" && computerChoice == "가위") ||
            //        (playerChoice == "보" && computerChoice == "바위")
            //        )
            //    {
            //        Console.WriteLine("플레이어 승리!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("컴퓨터 승리!");
            //    }
            //}


            // 2) 숫자맞추기
            int targetNumber = new Random().Next(1, 101);
            int guess = 0;
            int count = 0;
            Console.WriteLine("1 부터 100 사이의 숫자를 맞춰보세요.");

            while (guess != targetNumber)
            {

                Console.WriteLine("숫자를 입력해주세요: ");
                guess = int.Parse(Console.ReadLine());
                count ++;

                if (guess > targetNumber)
                {
                    Console.WriteLine("입력하신 숫자가 큽니다!");
                }
                else if(guess < targetNumber)
                {
                    Console.WriteLine("입력하신 숫자가 작습니다!");
                }else
                {
                    Console.WriteLine("정답입니다!");
                    Console.WriteLine($"축하드립니다 {count}번 만에 맞추셨습니다");
                }
               
            }

        }
    }
}