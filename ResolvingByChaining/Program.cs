using System;
using System.Collections.Generic;

namespace ResolvingByChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            HashMap map = new HashMap();
            map.Insert(129, 345);
            //map.Insert(129, 56);
            //map.Insert(2, 4567);
            //map.Insert(3, 678);
            map.Remove(129);
            // Console.WriteLine(map.Get(6));
            Dictionary<char, int> dic = new Dictionary<char, int>();
            dic.Add('A', 3);
            dic.Add('C', 56);
           
                //Console.WriteLine(dic['c']);
            
        }
    }
}
