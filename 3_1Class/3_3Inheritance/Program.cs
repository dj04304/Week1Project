namespace _3_3Inheritance
{
    internal class Program
    {
        // 부모 클래스
        public class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public void Eat()
            {
                Console.WriteLine("Animal is eating.");
            }

            public void Sleep()
            {
                Console.WriteLine("Animal is sleeping.");
            }
        }

        // 자식 클래스
        public class Dog : Animal //Animal 상속
        {
            public void Bark()
            {
                Console.WriteLine("Dog is Bark!");
            }
        }

        public class Cat : Animal
        {
            public void Meow()
            {
                Console.WriteLine("Cat is Meow!");
            }

            // 이런식으로 쓸 수 있지만, 좋지 않다. 그래서 사용할 수 있는 방법 -> 다형성
            public void Sleep()
            {
                Console.WriteLine("Cat Sleep");
            }

        }

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = "Bobby";
            dog.Age = 3;

            dog.Eat();
            dog.Sleep();
            dog.Bark();

            Cat cat = new Cat();
            cat.Name = "KKami";
            cat.Age = 5;

            cat.Eat();
            cat.Sleep();
            cat.Meow();

        }
    }
}