namespace AddSeparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddSeparator("ABCD", "^"));
            Console.WriteLine(AddSeparator("chocolate", "-"));
        }
        public static string AddSeparator(string str, string separator)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result += str[i];
                if (i != str.Length - 1)
                {
                    result += separator;
                }
            }
            return result;
        }
    }
}
