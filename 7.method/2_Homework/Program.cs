namespace _2_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 숫자 맞추기 게임
            Random random = new Random();
            int[] randomNum = new int[3];
            int attemt = 0;
            bool isTrue = true;

            for (int i = 0; i < randomNum.Length; i++) 
            {
                randomNum[i] = random.Next(1, 10);
            }

            // Play Game
            while(isTrue)
            {
                Console.WriteLine("3개의 숫자를 입력해주세요 (1 ~ 9)");
                int[] guess = new int[3]; 

                for(int i = 0; i < guess.Length; i++)
                {
                    guess[i] = int.Parse(Console.ReadLine());
                }

                int correct = 0;

                for(int i = 0; i < randomNum.Length; i++)
                {
                    for(int j = 0; j < guess.Length; j++)
                    {
                        if (guess[i] == randomNum[j])
                        {
                            correct++;
                            break;
                        }
                    }
                }
                attemt++;
                Console.WriteLine($"{attemt}번째 시도: {correct}개를 맞추셨습니다. ");

                if( correct == 3 ) 
                {
                    Console.WriteLine("축하드립니다! 모든 수를 맞추셨습니다!");
                    break;
                }
            }
          


        }
    }
}