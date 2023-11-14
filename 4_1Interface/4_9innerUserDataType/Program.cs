namespace _4_9innerUserDataType
{
    internal class Program
    {
        class Player
        {
            enum PlayerJob
            {
                NOVICE,
                KNIGHT,
                FIGHTER,
                BERSERKER,
                FIERMAGE
            }

            PlayerJob job = PlayerJob.NOVICE;

        }


        class Inven
        {
            public enum INVENDIR
            {
                ID_LEFT,
                ID_RIGHT,
                ID_UP,
                ID_DOWN
                
            }

            void SelectMove()
            {

            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            Inven inven = new Inven();
            //Player.
            Inven.INVENDIR IDIR = Inven.INVENDIR.ID_LEFT;

        }
    }
}