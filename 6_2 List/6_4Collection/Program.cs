namespace _6_4Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.Remove(2);

            for(int i = 0; i <list.Count; i++)
            {
                Console.WriteLine(i);
            }

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            //Dictionary 키와 값으로 구성, 중복된 키를 가질 수 없으며 키와 값의 쌍을 이룸
            Dictionary<string, int> scores = new Dictionary<string, int>(); // 빈 딕셔너리 생성
            scores.Add("Alice", 100); // 딕셔너리에 데이터 추가
            scores.Add("Bob", 80);
            scores.Add("Charlie", 90);
            scores.Remove("Bob"); // 딕셔너리에서 데이터 삭제

            foreach (KeyValuePair<string, int> pair in scores) // 딕셔너리 데이터 출력
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }

            // Stack 후입선출(LIFO Last In First Out) 구조를 가짐
            Stack<int> stack1 = new Stack<int>();  // int형 Stack 선언

            // Stack에 요소 추가
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);

            // Stack에서 요소 가져오기
            int value = stack1.Pop(); // value = 3 (마지막에 추가된 요소)


            //Queue는 선입선출(FIFO First In First Out)의 파이프식 구조를 가진 자료구조
            Queue<int> queue1 = new Queue<int>(); // int형 Queue 선언

            // Queue에 요소 추가
            queue1.Enqueue(1);
            queue1.Enqueue(2);
            queue1.Enqueue(3);

            // Queue에서 요소 가져오기
            int value2 = queue1.Dequeue(); // value = 1 (가장 먼저 추가된 요소)


            //HashSet은 중복되지 않은 요소들로 이루어진 집합이다.
            HashSet<int> set1 = new HashSet<int>();  // int형 HashSet 선언

            // HashSet에 요소 추가
            set1.Add(1);
            set1.Add(2);
            set1.Add(3);

            // HashSet에서 요소 가져오기
            foreach (int element in set1)
            {
                Console.WriteLine(element);
            }

        }
    }
}