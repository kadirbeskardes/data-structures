using System;
using System.Collections;
using System.Collections.Generic;

namespace MyHash
{
    public class MyHashArr
    {
        static string[] list = new string[10];
        public int HashFunc(string s)
        {
            int value = 0;
            for (int i = 0; i < s.Length; i++)
            {
                value = value + (byte)s[i];
            }
            return value % list.Length;
        }
        public bool Find(string s)
        {
            int index = HashFunc(s);
            if (list[index] == s) { return true; }
            for (int i = 1; i < list.Length - 1; i++)
            {
                if (list[(index + i) % list.Length] == s)
                { return true; }
            }
            return false;
        }
        public void Add(string s)
        {
            int index = HashFunc(s);
            if (list[index] == null)
            {
                list[index] = s;
                return;
            }
            for (int i = 0; i < list.Length - 1; i++)
            {
                if (list[(index + i) % list.Length] == null)
                {
                    list[(index + i) % list.Length] = s;
                    return;
                }
            }
        }
    }
}