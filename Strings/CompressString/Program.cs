namespace CompressString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CompressString("aaabbbcc"));
            Console.WriteLine(CompressString("aaabbbccdd"));
        }

        public static string CompressString(string input)
        {
            string result = "";
            int count = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (i + 1 < input.Length && input[i] == input[i + 1])
                {
                    count++;
                }
                else
                {
                    result += input[i] + count.ToString();
                    count = 1;
                }
            }
            return result;
        }
    }
}
