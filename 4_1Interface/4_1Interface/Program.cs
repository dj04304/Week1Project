namespace _4_1Interface
{
    internal class Program
    {
        //인터페이스 구현해보기

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