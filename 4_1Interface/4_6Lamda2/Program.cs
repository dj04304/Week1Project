namespace _4_6Lamda2
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            string[] name = new[] { "a", "b", "c", "d","E","f" };
            string[] age = new[] { "20", "30"};

            list = name.SelectMany(names => age).ToList();
            //list = name.SelectMany(names => age, (names, ages) => names).ToList();


            foreach(string a in list)
            {
                Console.WriteLine(a);
            }

        }
    }
}