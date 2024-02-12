namespace NumberOfWords
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine(CountWords("Hello World! how are you?"));
            Console.WriteLine(CountWords("OK"));
        }

        public static int CountWords(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int count = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
            }

            return count;
        }
    }
}

