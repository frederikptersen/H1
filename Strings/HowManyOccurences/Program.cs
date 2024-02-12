namespace HowManyOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HowManyOccurences("do it now", "do"));
            Console.WriteLine(HowManyOccurences("do it now", "o"));
            Console.WriteLine(HowManyOccurences("do it now", "it"));
        }

        public static int HowManyOccurences(string str, string subStr)
        {
            int count = 0;
            int i = 0;
            while ((i = str.IndexOf(subStr, i)) != -1)
            {
                i += subStr.Length;
                count++;
            }
            return count;
        }
    }
}
    

