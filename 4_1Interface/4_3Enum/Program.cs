namespace _4_3Enum
{
    internal class Program
    {
        //enum의 활용, 게임상태라던지(메뉴, 플레잉, 일시정지, 게임오버), 방향(위 아래 좌 우), 아이템 등급(1, 2, 3, 4) 를 정할 수 있다.
        public enum Month
        {
            Jan = 1,
            Feb,
            Mar,
            Apr,
            May,
            Jun,
            July,
            Aug,
            Sep,
            Oct,
            Nov,
            Dec
        }

        public static void prcessMonth(int month)
        {
            if(month > (int)Month.Jan && (int)Month.Dec < 13) 
            {
                Month selectMonth = (Month)month;
                Console.WriteLine("선택한 월은 {0} 입니다.", selectMonth);

            }
            else
            {
                Console.WriteLine("올바른 월을 입력해주세요");
            }

        }

        static void Main(string[] args)
        {
            int userInput = 7;
            prcessMonth(userInput);
        }
    }
}