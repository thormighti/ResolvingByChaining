using System;
using System.Collections.Generic;
using System.Text;

namespace ResolvingByChaining
{
    class LinkedHashEntry
    {
        int key;
        int valueOf;
        LinkedHashEntry next; // linker to the next value

        public LinkedHashEntry(int key, int valueOf)
        {
            this.key = key;
            this.valueOf = valueOf;
            this.next = null;
        }
        public int Key { get => key; }
        public int Value { get { return this.valueOf; } set { valueOf = value; } }
        public LinkedHashEntry Next { get { return next; } set { next = value; } }

    }
}
