namespace _6_2_List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// 랜덤된 플레이어의 능력치를 구사하는 코드
            //// 플레이어의 공격력, 방어력, 체력, 스피드를 저장할 배열
            //int[] playerStats = new int[4];

            //// 능력치를 랜덤으로 생성하여 배열에 저장
            //Random rand = new Random();
            //for (int i = 0; i < playerStats.Length; i++)
            //{
            //    playerStats[i] = rand.Next(1, 11);
            //}

            //// 능력치 출력
            //Console.WriteLine("플레이어의 공격력: " + playerStats[0]);
            //Console.WriteLine("플레이어의 방어력: " + playerStats[1]);
            //Console.WriteLine("플레이어의 체력: " + playerStats[2]);
            //Console.WriteLine("플레이어의 스피드: " + playerStats[3]);

            //3) 학생들의 성적 평균 구하기
            //int[] scores = new int[5];

            //for(int i = 0; i < scores.Length; i++)
            //{
            //    Console.Write("학생" + (i + 1) + "의 성적을 입력하세요: ");
            //    scores[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = 0;
            //for(int i = 0; i < scores.Length ; i++) 
            //{ 
            //    sum += scores[i];
            //}

            //double average = (double)sum / scores.Length;
            //Console.WriteLine("성적 평균은 " + average + "입니다.");

            Random random = new Random();  // 랜덤 객체 생성
            int[] numbers = new int[3];  // 3개의 숫자를 저장할 배열

            // 3개의 랜덤 숫자 생성하여 배열에 저장
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 10);
            }

            int attempt = 0;  // 시도 횟수 초기화
            while (true)
            {
                Console.Write("3개의 숫자를 입력하세요 (1~9): ");
                int[] guesses = new int[3];  // 사용자가 입력한 숫자를 저장할 배열

                for(int i = 0; i < guesses.Length; i++)
                {
                    guesses[i] = int.Parse(Console.ReadLine()); //3번의 입력을 받음
                }

                int correct = 0; 
                for(int i = 0; i < numbers.Length; i++)
                {
                    for(int j = 0; j < guesses.Length; j++)
                    {
                        if (numbers[i] == guesses[j])
                        {
                            correct++;
                            break;
                        }
                    }
                }

                attempt++;
                Console.WriteLine($"시도 {attempt}#: {correct} 개의 숫자를 맞추셨습니다.");

                if(correct == 3)
                {
                    Console.WriteLine("축하합니다! 모든 수를 맞추셨습니다!");
                    break;
                }
            }


            // 2차원 배열의 선언과 초기화
            int[,] array3 = new int[2, 3];  // 2행 3열의 int형 2차원 배열 선언

            // 다차원 배열 초기화
            array3[0, 0] = 1;
            array3[0, 1] = 2;
            array3[0, 2] = 3;
            array3[1, 0] = 4;
            array3[1, 1] = 5;
            array3[1, 2] = 6;

            // 선언과 함께 초기화
            int[,] array2D = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            // 3차원 배열의 선언과 초기화
            int[,,] array3D = new int[2, 3, 4]
            {
                { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } },
                { { 13, 14, 15, 16 }, { 17, 18, 19, 20 }, { 21, 22, 23, 24 } }
            };

        }
    }
}