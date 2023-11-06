namespace _2_Homework2
{
    internal class Program
    {
        static char[,] board = new char[3, 3];
        static char currentPlayer = 'X';

        static void Main(string[] args)
        {
            InitializeBoard();

            while (true)
            {
                DisplayBoard();
                PlayerInputNum();

                if (IsGameOver())
                {
                    DisplayBoard();
                    Console.WriteLine("게임 종료!");
                    break;
                }

                SwitchPlayer();
            }
        }

        // 보드 초기화
        static void InitializeBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }

        // 보드판 생성
        static void DisplayBoard()
        {
            Console.Clear();
            Console.WriteLine("  0 1 2");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + " ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    if (col < 2)
                    {
                        Console.Write("|");
                    }
                        
                }
                Console.WriteLine();
                if (row < 2)
                {
                    Console.WriteLine("  -+-+-");
                }
            }
        }

        static void PlayerInputNum()
        {
            int row, col;
            do
            {
                Console.Write($"플레이어 {currentPlayer}, 행과 열을 입력하세요 (예: 0 0, 주의!: 0 부터 2까지만 입력해주세요): ");
                string[] input = Console.ReadLine().Split(' ');
                row = int.Parse(input[0]);
                col = int.Parse(input[1]);
            } while (row < 0 || row >= 3 || col < 0 || col >= 3 || board[row, col] != ' ');

            board[row, col] = currentPlayer;
        }

        // 승자가 생기거나, 무승부시 게임 종료
        static bool IsGameOver()
        {
            return IsWinner() || IsBoardFull();
        }

        // 승자 함수
        static bool IsWinner()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                //가로 또는 세로 승리
                if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                    return true;
                if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                    return true;
            }

            // 대각선 승리
            if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
                return true;
            if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
                return true;

            return false;
        }

        // 무승부
        static bool IsBoardFull()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == ' ')
                        return false;
                }
            }
            return true;
        }

        // 플레이어 선공 교체
        static void SwitchPlayer()
        {
            if (currentPlayer == 'X')
            {
                currentPlayer = 'O';
            }
            else
            {
                currentPlayer = 'X';
            }
        }
    }
}
    //{
    //   static int[,] board = new int[5, 5]
    //    {
    //        {1, 1, 1, 1, 1 },
    //        {1, 0, 0, 0, 1 },
    //        {1, 0, 0, 0, 1 },
    //        {1, 0, 0, 0, 1 },
    //        {1, 1, 1, 1, 1 }
    //    };

    //    static bool isPlay = true;
    //    static int playerX = 0;
    //    static int playerY = 1;
    //    static int[] choice;

    //    static void Board()
    //    {
            
    //        for (int i = 0; i < board.GetLength(0); i++)
    //        {
    //            for(int j = 0; j < board.GetLength(1); j++)
    //            {
    //                if (board[i, j] == 0)
    //                {
    //                    Console.Write("ㅡ");
    //                }
    //                else
    //                {
    //                    Console.Write("■");
    //                }
    //            }
    //            Console.WriteLine();
    //        }
    //    }
        
    //    static void PlayerInput()
    //    {
    //        Console.WriteLine("게임을 시작합니다.");
    //        Console.WriteLine("선공은 1P입니다. 알맞은 좌표에 숫자를 입력하여 수를 놔주세요");
    //        while(isPlay)
    //        {
    //            string input = Console.ReadLine();
    //            string[] arr = input.Split(' ');

    //            int firstInput = int.Parse(arr[0]);
    //            int secondInput = int.Parse(arr[1]);

    //            for (int i = 0; i < board.GetLength(0); i++)
    //            {
    //                for(int j = 0; j < board.GetLength(1); j++)
    //                {
    //                    if (board[i, j] == 1)
    //                    {
    //                        Console.WriteLine("잘못 두셨습니다. 다시 입력해주세요");
    //                        break;
    //                    }
    //                    else if (
    //                        board[i, j] == board[0, j] 
    //                        || board[i, j] == board[i, 0] 
    //                        || board[i, j] == board[4, j]
    //                        || board[i, j] == board[i, 4]
    //                        )
    //                    {
    //                        Console.WriteLine("잘못두셨습니다. 다시 입력해주세요");
    //                        break;
    //                    }else
    //                    {
    //                        Console.WriteLine(board[i, j]);
    //                    }

    //                }
    //            }

    //        }
            


    //    }

    //    static void Main(string[] args)
    //    {
    //        // 틱택토
    //        // 2인 플레이어, o x 말 o 선공
    //        // 3 X 3 판

    //        Board();

    //        while(isPlay)
    //        {
    //            Console.WriteLine("게임을 시작합니다. Player를 선택해주세요 (0 = 1p, 1 = 2p)");
    //            int playerChioce = int.Parse(Console.ReadLine());

    //            //플레이어 선택
    //            if(playerChioce == 0)
    //            {
    //                Console.WriteLine("1P를 선택하셨습니다.");
    //            }else if(playerChioce == 1)
    //            {
    //                Console.WriteLine("2p를 선택하셨습니다.");
    //            }else
    //            {
    //                Console.WriteLine("잘못된 입력입니다. 0 또는 1을 선택해주세요.");
    //            }


    //        }

    //    }
    //}
    //}