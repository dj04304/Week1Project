namespace _3_5Abstract
{
    internal class Program
    {
        // 추상클래스 내에 있는 추상 메서드는 상속받을 경우 반드시 구현해야 한다.
        abstract class Shape
        {
            public abstract void Draw();
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Circle");
            }
        }

        class Square : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Square");
            }
        }

        class Triangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Triangle");
            }
        }
        static void Main(string[] args)
        {
            //           Shape shape = new Shape(); 추상메서드는 인스턴스 또는 객체화 X

            List<Shape> shapeList = new List<Shape>();
            shapeList.Add(new Circle());
            shapeList.Add(new Square());
            shapeList.Add(new Triangle());

            foreach(Shape shape in shapeList)
            {
                shape.Draw();
            }

        }
    }
}