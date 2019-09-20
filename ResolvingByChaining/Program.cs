using System;

namespace ResolvingByChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            HashMap map = new HashMap();
            map.Insert(129, 345);
            map.Insert(129, 56);
            map.Insert(2, 4567);
            map.Insert(3, 678);
            Console.WriteLine(map.Get(129));
            Console.WriteLine(map.Exist(129));
        }
    }
}
