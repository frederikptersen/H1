namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3, 8, 9, 7, 6 };
            int K = 3;
            int[] result = RotateArray(A, K);
            Console.WriteLine("Result: ");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static int[] RotateArray(int[] A, int K)
        {
            int[] result = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                result[(i + K) % A.Length] = A[i];
            }
            return result;
        }
    }
}
