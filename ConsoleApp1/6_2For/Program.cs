namespace _6_2For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 반복문

            // for문 기초
            //for(int i =0 ; i < 10 ; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // for문 기초2
            //int sum = 0;

            //for(int i = 1; i < 6; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine($"1 부터 5까지 더한 합은 {sum} 입니다.");

            // while문 기초
            //int j = 0;
            //while( j < 10)
            //{
            //    Console.WriteLine(j);
            //    j++;
            //}

            // while문 기초 2
            //int count = 0;
            //while(count > 10)
            //{
            //    Console.WriteLine("적을 처치했습니다. 남은 적 수: " + (10 - count - 1) );
            //    count++;
            //}

            //Console.WriteLine("축하합니다 승리하셨습니다!");


            // do while문 do 안에 있는 코드는 무조건 한번은 실행되며, while의 조건이 참인 경우 실행된다.
            //int sum = 0;
            //int num;

            //do
            //{
            //    Console.WriteLine("숫자를 입력하세요(0 입력시 종료): ");
            //    num = int.Parse(Console.ReadLine());
            //    sum += num;
            //} while (num != 0);

            //Console.WriteLine("합계: " + sum);

            //foreach문 배열이나 컬렉션에 대한 반복문시 사용된다.
            //string[] inventory = { "검", "방패", "활", "화살", "물약" };

            //foreach(string item in inventory)
            //{
            //    Console.WriteLine(item);
            //}

            // 구구단 출력
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 2; j < 10; j++)
            //    {
            //        Console.Write(j + " x " + i + " = " + (i * j) + "\t");
            //    }
            //    Console.WriteLine();
            //}

            // break, continue braek는 반복을 멈추고 탈출, continue는 지정된 값을 제외하고 반복

            // break, continue 기초
            //for (int i = 1; i < 11; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue; // 3의 배수인 경우 다음 숫자로 넘어감
            //    }

            //    Console.WriteLine(i);
            //    if (i == 7)
            //    {
            //        break; // 7이 출력된 이후에는 반복문을 빠져나감
            //    }
            //}
            

            //break continue 예제

            int sum = 0;

            while (true) //무한 루프
            {
                Console.Write("숫자를 입력하세요: ");
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    Console.WriteLine("프로그램을 종료합니다.");
                    break;
                }

                if (input < 0)
                {
                    Console.WriteLine("음수는 무시합니다.");
                    continue;
                }

                sum += input;
                Console.WriteLine("현재까지의 합: " + sum);
            }

            Console.WriteLine("합계: " + sum);
        }
    }
}