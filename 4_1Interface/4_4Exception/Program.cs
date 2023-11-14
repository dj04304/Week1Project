using static _4_4Exception.Program;

namespace _4_4Exception
{
    internal class Program
    {
        public class NegativeNumberException : Exception
        {
            public NegativeNumberException(string message) : base(message)
            {
            }
        }
        static void Main(string[] args)
        {                     
            try
            {
                int number = -10;
                if (number < 0)
                {
                    throw new NegativeNumberException("음수는 처리할 수 없습니다.");
                }
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("예외가 발생했습니다: " + ex.Message);
            }

        }
     }
}