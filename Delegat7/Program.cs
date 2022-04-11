using System;

namespace Delegat7

{
    public delegate int SubDelegate(int a, int b);


    class Program
    {

        static void Main(string[] args)

        {
            //SubDelegate sD = (s,d) =>
            //{
            //int res = s - d;
            //Return res;
            //}

            int c = new SubDelegate((s, d) =>
            {
                int res = s - d;
                return res;

            }).Invoke(9, 6);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
