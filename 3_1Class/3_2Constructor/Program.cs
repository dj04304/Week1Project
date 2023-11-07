namespace _3_2Constructor
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;
            
            // 디폴트 생성자
            public Person()
            {
                name = "UnKnown";
                age = 0;
                Console.WriteLine("Person 객체 생성");
            }

            public Person(string newName, int newAge)
            {
                name = newName;
                age = newAge;
                Console.WriteLine("Person 객체 생성");
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Name: {name}, Age: {age}");
            }

        }

        static void Main(string[] args)
        {
            Person person = new Person();
            Person person2 = new Person("John", 25);
            person2.PrintInfo();
        }
    }
}