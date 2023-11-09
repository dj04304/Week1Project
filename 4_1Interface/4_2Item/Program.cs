namespace _4_2Item
{
    internal class Program
    {
        // 인터페이스 아이템 구현
        public interface IUsable
        {
            void Use();
        }

        public class Item : IUsable
        {
            public string Name { get; set; }

            public void Use()
            {
                Console.WriteLine("아이템 {0} 을 사용했습니다.", Name);
            }

        }

        public class Player
        {
            public void UseItem(IUsable item)
            {
                item.Use();
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            Item item = new Item() {Name = "Health Potion" } ;
            player.UseItem(item);

        }
    }
}