using System;
using System.Collections.Generic;
using System.Text;

namespace ResolvingByChaining
{
    class HashMap
    {
        public const int TABLE_SIZE = 127; // 2^7 - 1
        LinkedHashEntry[] table;
        public HashMap()
        {
            table = new LinkedHashEntry[TABLE_SIZE];

        }
        public int Get(int key)
        {
            int hash = key % TABLE_SIZE; // Division Method; good marking
            if (table[hash] == null)
            {
                return -1;
            }
            else
            {
                LinkedHashEntry entry = table[hash]; // marking that entry
                while (entry != null && entry.Key != key)
                {
                    entry = entry.Next;

                }
                if (entry == null) { return -1; }
                else
                {
                    return entry.Value;
                }
            }
        }
        public void Insert(int key, int value)
        {
            int hash = key % TABLE_SIZE;
            if (table[hash] == null) // value to be given at main
            {
                table[hash] = new LinkedHashEntry(key, value);
            }
            else
            {
                LinkedHashEntry entry = table[hash];
                while (entry.Next != null && entry.Key != key)
                {
                    entry = entry.Next;
                }
                if (entry.Key == key)
                {
                    entry.Value = value;
                }
                else
                {
                    entry.Next = new LinkedHashEntry(key, value);
                }

            }
        }
        public void Remove(int key)
        {
            int hash = key % TABLE_SIZE;
            LinkedHashEntry prevEntry = null;
            LinkedHashEntry entry = table[hash];
            while(entry.Next != null && entry.Key != key)
            {
                prevEntry = entry;
                entry = entry.Next;
            }
            if(entry.Key != key)
            {
                if(prevEntry != null)
                {
                    table[hash] = entry.Next;
                }
                else
                {
                    prevEntry.Next = entry.Next;
                }
            }
        }
        public bool Exist(int key)
        {
            return table[Get(key)] != null;
        }
    }
}
