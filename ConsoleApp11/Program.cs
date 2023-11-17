namespace ConsoleApp11
{
    internal class Solution
    {
        static public string solution(int num)
        {
            return (num % 2 == 0) ? "Even" : "Odd";
        }

        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요: ");
            int num;

            // 사용자로부터 정수를 입력받습니다.
            if (int.TryParse(Console.ReadLine(), out num))
            {
                string result = solution(num);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("유효한 정수를 입력하세요.");
            }

        }
    }
}