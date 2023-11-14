namespace _4_1Interface
{
    internal class Program
    {

        //인터페이스 구현해보기
        
        // 인터페이스를 사용하는 이유
        // 1. 코드의 재 사용성 -> 인터페이스를 사용하면 다른 클래스에서 해당 인터페이스를 구현하여 동일한 기능을 구현할 수 있다.
        // 인터페이스를 통해 다양한 클래스가 동일한 동작을 수행할 수 있기 때문에 재사용성이 용이하다.

        // 2. 다중 상속 제공
        // C#에서 클래스는 단일 상속만을 지원하지만, 인터페이스는 다중 상속을 지원한다. 클래스가 여러 인터페이스를 구현함으로써 여러 개의 기능을 조합할 수 있다.
        // 다중 상속을 통해 클래스는 더 다양한 동작을 수행해 낼 수 있다.

        // 3. 유연한 설계
        // 인터페이스를 사용하면 클래스와 인터페이스 간에 느슨한 결합을 형성할 수 있다. 클래스는 인터페이스를 구현하기만 하면 되므로
        // 클래스의 내부 구현에 대한 변경 없이 인터페이스의 동작을 변경하거나 새로운 인터페이스를 추가할 수 있다. 유연한 설계가 가능하다.
        
        // 인터페이스는 해당 클래스에게 이런식으로 구현해! 라고 해주는 역할

        public interface IMovable
        {
            void Move(int x, int y);
        }

        public class Player : IMovable
        {
            public void Move(int x, int y)
            {

            }

        }

        public class Enemy : IMovable
        {
            public void Move(int x, int y)
            {
                
            }
        }

        static void Main(string[] args)
        {
            IMovable movable = new Player();
            IMovable movable1 = new Enemy();

            movable.Move(1, 2);
            movable1.Move(2, 3);

        }
    }
}