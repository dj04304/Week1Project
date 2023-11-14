namespace _4_7FunAct
{
    class GameCharacter
    {
        private Action<float> healthChagedCallback;

        private float health;

        public float Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
                healthChagedCallback?.Invoke(health);
            }
        }

        public void SetHaelthChagedCallback(Action<float> callback)
        {
            healthChagedCallback = callback;
        }

    }


    internal class Program
    {
        static int Add(int x , int y)
        {
            return x + y;
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            // 앞에 두 int는 받는 매겨변수, 마지막 int는 반환값
            Func<int, int, int> addFunc = Add;
            int result = addFunc(3, 5);

            Console.WriteLine("결과: " + result);

            Action<string> printAction = PrintMessage;
            printAction("Hello, world");

            Console.WriteLine("//////////////////////////////////////////////////////////////////");

            GameCharacter character = new GameCharacter();
            character.SetHaelthChagedCallback(health =>
            {
                if (health <= 0)
                {
                    Console.WriteLine("캐릭터 사망!");
                }
            });

            character.Health = 0;
        }
    }


}