using System;
using System.Collections.Generic;

namespace MyHash
{
    public class MyHashLLString
    {
        static LinkedList<string>[] list = new LinkedList<string>[10];
        private int HashFunc(string data)
        {
            int value = 0;

            for (int i = 0; i < data.Length; i++)
            {
                value = value + (byte)data[i];
            }
            return value % list.Length;
        }
        public void Add(string data)
        {
            int index = HashFunc(data);
            if (list[index] == null)
            {
                LinkedList<string> newL = new LinkedList<string>();
                newL.AddFirst(data);
                list[index] = newL;
            }
            else
            {
                LinkedList<string> newL = list[index];
                newL.AddLast(data);
                list[index] = newL;
            }
        }
        public bool Find(string data)
        {
            int index = HashFunc(data);
            if (list[index] == null)
            {
                return false;
            }
            else
            {
                LinkedList<string> newL = list[index];
                LinkedListNode<string> first = newL.First;
                while (first != null)
                {
                    if (first.Value.Equals(data))
                    {
                        return true;
                    }
                    first = first.Next;
                }
                return false;
            }
        }

        public void Print()
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine();
                if (list[i] == null)
                {
                    continue;
                }
                LinkedListNode<string> newL = list[i].First;

                while (newL != null)
                {
                    Console.Write($"{newL.Value} ");
                    newL = newL.Next;
                }
            }
        }
    }
}