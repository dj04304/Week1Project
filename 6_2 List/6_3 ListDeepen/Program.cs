namespace _6_3_ListDeepen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] map = new int[5, 5];

            //// GetLength(0) 는 행의 갯수, GetLength(1)은 열의 갯수이다.
            //for (int i = 0; i < map.GetLength(0); i++)
            //{
            //    for(int j = 0; j < map.GetLength(1); j++)
            //    {
            //        map[i, j] = i + j;
            //    }
            //}

            // 2차원 배열을 통한 게임맵
            int[,] map = new int[5, 5]
            {
                {1, 0, 1, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 1, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 1, 0, 1 }
            };

            for(int i = 0; i < map.GetLength(0); i++) 
            {
                for(int j = 0;  j < map.GetLength(1); j++)
                {
                    if (map[i, j] == 1)
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write("□");
                    }
                }
                Console.WriteLine( );
            }

        }
    }
}