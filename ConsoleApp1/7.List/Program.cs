namespace _7.List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 배열
            //int[] arr1 = new int[5];
            //string[] arr2 = new string[3];

            //int num = 0;

            //for (int i = 0;  i  < arr1.Length; i++)
            //{
            //    arr1[i] = i;
            //}

            //num = arr1[0];

            //Console.WriteLine(num);

            // 배열에 직접 값 넣기
            int[] itemPrices = { 100, 200, 300, 400, 500 };
            int totalPrice = 0;

            for(int i =  0; i < itemPrices.Length; i++)
            {
                totalPrice += itemPrices[i];    
            }

            Console.WriteLine($"총 아이템 가격은 {totalPrice}gold 입니다.");

        }
    }
}