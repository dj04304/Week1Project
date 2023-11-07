namespace _3_4Virtual
{
    internal class Program
    {
        public class Unit
        {
            // 가상 메서드 virtual
            // 자식 메서드가 언제든지 재정의를 했을 수 있다.
            public virtual void Move()
            {
                Console.WriteLine("두발로 걷기");
            }
            // virtual이면 실형태가 다를 수 있으니 실형태에 재정의가 되어있는지 확인해봐라

            public void Attack()
            {
                Console.WriteLine("Unit 공격");
            }
        }

        public class Marine : Unit
        {

        }

        public class Zergling : Unit
        {
            public override void Move()
            {
                Console.WriteLine("네 발로 걷기");
            }
        }

        static void Main(string[] args)
        {
            //Marine marine = new Marine();
            //marine.Move();
            //marine.Attack();

            //Zergling zergling = new Zergling();
            //zergling.Move(); // 네발로 걷기 출력
            //zergling.Attack();

            //Unit 으로 관리
            // Unit은 참조의 형태, Marine, Zergling은 실 형태
            List<Unit> list = new List<Unit>();
            list.Add(new Marine());
            list.Add(new Zergling());

            foreach(Unit unit in list)
            {
                unit.Move(); // 두발로 걷기 출력, virtual사용시 두발, 네발로 걷기 출력
            }

        }
    }
}