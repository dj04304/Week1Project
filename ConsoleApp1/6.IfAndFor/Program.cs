namespace _6.IfAndFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if문 기초
            int playerScore = 80;

            if (playerScore > 69)
            {
                Console.WriteLine("플레이어 점수는 70점 이상입니다. 합격입니다!");
            }

            Console.WriteLine("프로그램이 종료됩니다.");

            Console.WriteLine("-------------------- 구분선 --------------------");

            //else문 기초
            int itemCount = 0;
            string itemName = "HP 포션";

            if(itemCount > 0)
            {
                Console.WriteLine($"보유한 {itemName}의 수량: {itemCount}");
            }else
            {
                Console.WriteLine($"보유한 {itemName}이 없습니다.");
            }

            Console.WriteLine("-------------------- 구분선 --------------------");


            //else if 문
            int score = 100;
            string playerRank = "";

            // if if 두 번 써서 질문하면 가장 아래 질문에 답하기 때문에 else if를 사용
            if (score >= 90)
            {
                playerRank = "Diamond";
            }
            else if (score >= 80)
            {
                playerRank = "Platinum";
            }
            else if (score >= 70)
            {
                playerRank = "Gold";
            }
            else if (score >= 60)
            {
                playerRank = "Silver";
            }
            else
            {
                playerRank = "Bronze";
            }

            Console.WriteLine("플레이어의 등급은 {0} 입니다." , playerRank);


            Console.WriteLine("-------------------- 구분선 --------------------");


            //switch 문

            Console.WriteLine("게임을 시작합니다.");
            Console.WriteLine("1: 전사 / 2: 마법사 / 3: 궁수");
            Console.Write("직업을 선택하세요: ");
            string job = Console.ReadLine();

            switch (job)
            {
                case "1":
                    Console.WriteLine("전사를 선택하셨습니다.");
                    break; 
                case "2":
                    Console.WriteLine("마법사를 선택하셨습니다.");
                    break;
                case "3":
                    Console.WriteLine("궁수를 선택하셨습니다.");
                    break;

                default: // 생략 가능
                    Console.WriteLine("올바른 값을 입력해주세요.");
                    break;
            }

            Console.WriteLine("게임을 종료합니다.");


            Console.WriteLine("-------------------- 구분선 --------------------");


            // 삼항 연산자 앞의 조건이 참이면 앞의 값을, 거짓이면 뒤를 return

            int currentExp = 1200;
            int requireExp = 2000;

            string result = (currentExp >= requireExp) ? "레벨 업 가능" : "레벨 업 불가능";
            Console.WriteLine(result);

        }
    }
}