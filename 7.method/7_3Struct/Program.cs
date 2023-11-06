namespace _7_3Struct
{
    internal class Program
    {
        //구조체 
        struct Person
        {
            public String name;
            public int age;

            public void PrintInfo()
            {
                Console.WriteLine($"이름: {name}, 나이: {age}");
            }

        }
        
        static void Main(string[] args)
        {
            Person person;
            person.name = "john";
            person.age = 15;

            person.PrintInfo();

        }
    }
}