namespace SortChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortChars("hello"));
            Console.WriteLine(SortChars("hello world"));
        }

        public static char[] SortChars(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Sort(charArray);
            Array.Reverse(charArray);
            return charArray;
        }
    }
}

