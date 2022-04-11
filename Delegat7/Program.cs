using System;

namespace Delegat7

{
    public delegate bool CompareDelegate(int a, int b);


    class Program
    {

        static void Main(string[] args)
        {
            CompareDelegate cD = (x, y) => x == y;
            bool result = cD(9, 10);
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
