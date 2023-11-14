namespace _4_8Property
{
    class Player
    {
        int Atk = 10;

        public int ProAtk
        {
            get 
            {
                if(9999 < Atk)
                {
                    Console.WriteLine("잘못된 수치입니다.");
                }
                return Atk;
            }
            // 무조건 int 하나가 들어온다고 생각한다.
            // 그런 외부 값들을 프로퍼티에서는 value라고 기호로 정의해 놨다.
            set
            {
                Atk = value;
            }
        }

        public int GetAtk()
        {
            return Atk;
        }

        public void SetAtk(int value)
        {
            Atk = value;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.ProAtk = 100;

        }
    }
}