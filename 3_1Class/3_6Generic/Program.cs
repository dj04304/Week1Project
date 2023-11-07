namespace _3_6Generic
{
    internal class Program
    {
        class Stack<T>
        {
            private T[] element;
            private int top;

            public Stack()
            {
                element = new T[100];
                top = 0;
            }

            public void Push(T item)
            {
                element[top++] = item;
            }
            public T Pop()
            {
                return element[--top];
            }

        }
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            Console.WriteLine(intStack.Pop());

        }
    }
}