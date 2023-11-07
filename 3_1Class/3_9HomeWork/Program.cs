namespace _3_9HomeWork
{
    /// <summary>
    /// 스네이크 게임
    /// </summary>
    internal class Program
    {
        // 가로 세로길이, 점수
        static int width = 40;
        static int height = 20;
        static int score = 0;

        // 뱀의 최대 길이 100
        static int[] X = new int[100];
        static int[] Y = new int[100];

        //꼬리 길이를 따로 관리
        static int tailLength = 1;

        //음식
        static int foodX;
        static int foodY;

        //랜덤 값
        static Random random = new Random();

        //Gameover
        static bool isGameOver = false;

        // enum Direction, 방향키 함수
        static Direction direction = Direction.RIGHT;
        
        
        // 화면 초기값
        static void InitialValue()
        {
            X[0] = width - 30;
            Y[0] = height / 2;

            foodX = random.Next(1, width - 1);
            foodY = random.Next(1, height -1);
        }


        // 보드판 만들기 함수
        static void Board()
        {
            Console.Clear();

            // 가로 열 네모칸
            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("■");
                Console.SetCursorPosition(i, height - 1);
                Console.WriteLine("■");
            }

            // 세로 열 네모칸
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("■");
                if (i > 0 && i < width - 2 && i < height - 1)
                {
                    Console.SetCursorPosition(width, i);
                    Console.WriteLine("■");
                }
            }
        }

        //뱀 그리기
        static void Snake()
        {
            for (int i = 0; i < tailLength; i++)
            {
                // 뱀 길이가 0이 아니면
                if (X[i] != 0 || Y[i] != 0)
                {
                    Console.SetCursorPosition(X[i], Y[i]);
                    Console.Write("■");
                    //width++;
                }
            }
        }

        // 꼬리 길이 증가
        static void PlusTail()
        {
            X[tailLength] = X[tailLength - 1];
            Y[tailLength] = Y[tailLength - 1];
            tailLength++;
        }

        //음식 그리기
        static void Food()
        {
            Console.SetCursorPosition(foodX, foodY);
            Console.WriteLine("●");
        } 

        // 음식과 충돌시 함수
        static void CollisionFood()
        {
            if (X[0] == foodX && Y[0] == foodY)
            {
                score++;

                foodX = random.Next(1, width - 1);
                foodY = random.Next(1, height - 1);

                PlusTail();

            }
        }

        /// <summary>
        /// 단축키를 할당하는 코드
        /// </summary>
        static void Input()
        {
            // Console.KeyAvailable, 현재 입력 버퍼에 대기중인 키보드 입력이 있는지의 여부를 알려줌
            // 즉, 사용자가 키를 누르면 true, 아니면 false를 반환해준다.
            if (Console.KeyAvailable)
            {
                //Console.ReadKey(true)는 true매개변수를 전달하여 사용자가 누른 key를 화면에 표시하지 않는다.
                // 이는 키보드 입력을 기다리는 메서드이며, .key를 하면 어떤키를 눌렀는지판단하고, 이에 따른 동작을 수행한다.
                var key = Console.ReadKey(true).Key;
                
                switch(key)
                {
                    case ConsoleKey.UpArrow:
                        if(direction != Direction.DOWN)
                        {
                            direction = Direction.UP;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (direction != Direction.UP)
                        {
                            direction = Direction.DOWN;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (direction != Direction.RIGHT)
                        {
                            direction = Direction.LEFT;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (direction != Direction.LEFT)
                        {
                            direction = Direction.RIGHT;
                        }
                        break;
                }
            }
        }

        // 뱀 움직이기
        static void Move()
        {
            int newHeadX = X[0];
            int newHeadY = Y[0];

            switch (direction)
            {
                case Direction.UP :
                    newHeadY--;
                    break;
                case Direction.DOWN:
                    newHeadY++;
                    break;
                case Direction.LEFT:
                    newHeadX--;
                    break;
                case Direction.RIGHT:
                    newHeadX++;
                    break;
            }

            // 꼬리 위치를 옮겨줌
            /*
                ex) tailLength 가 4라면
                x[4] = x[3]
                x[3] = x[2]
                x[2] = x[1]
                x[1] = x[0]
             */
            for (int i = tailLength - 1; i > 0; i--)
            {
                X[i] = X[i - 1];
                Y[i] = Y[i - 1];
            }

            // 머리 위치 업데이트
            X[0] = newHeadX;
            Y[0] = newHeadY; 

        }

        // 게임 오버
        static void GameOver()
        {
            if (X[0] == 0 || X[0] == width || Y[0] == 0 || Y[0] == height)
            {
                isGameOver = true;
                Console.WriteLine($"게임 오버, 당신의 점수는 {score} 입니다.");
            }
        }

        static void Main(string[] args)
        {
            InitialValue();

            while (!isGameOver)
            {
                Board();

                Input();

                Snake();
                Food();
                CollisionFood();
                //PlusTail();
                Move();

                Thread.Sleep(100);

                GameOver();
            }
        }

        public enum Direction
        {
            LEFT,
            RIGHT,
            UP,
            DOWN
        }

    }
}


