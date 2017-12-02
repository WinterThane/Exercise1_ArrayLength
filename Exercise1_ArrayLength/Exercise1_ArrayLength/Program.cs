using System;

namespace Exercise1_ArrayLength
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = new int[5];
            int lenghtA = arrayA.Length;
            Console.WriteLine("Length of arrayA is: {0}", lenghtA.ToString());
            Console.WriteLine();

            int[,] arrayB = new int[5, 10];
            Console.WriteLine("Length of arrayB is: {0}", arrayB.Length.ToString());

            Console.ReadLine();
        }
    }
}
