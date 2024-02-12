namespace RevertWordsOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RevertWordsOrder("Hello world"));
            Console.WriteLine(RevertWordsOrder("This is a test")); 
        }

        public static string RevertWordsOrder(string input)
        {
            string[] words = input.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}

