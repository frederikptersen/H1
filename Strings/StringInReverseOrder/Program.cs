namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringInReverse("Hello"));
            Console.WriteLine(StringInReverse("Goodbye you!"));
        }

        public static string StringInReverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
