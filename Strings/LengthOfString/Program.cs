namespace LengthOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfString("computerprogram"));
            Console.WriteLine(LengthOfString("ice cream"));
        }

        public static int LengthOfString(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                count++;
            }
            return count;
        }
    }
}
