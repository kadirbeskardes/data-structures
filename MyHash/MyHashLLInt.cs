using System;
using System.Collections;
using System.Collections.Generic;

namespace MyHash
{
    public class MyHashLLInt
    {
        static LinkedList<int>[] list = new LinkedList<int>[10];
        private int HashFunc(int data)
        {
            return data % list.Length;
        }
        public void Add(int data)
        {
            int index = HashFunc(data);
            if (list[index] == null)
            {
                LinkedList<int> newL = new LinkedList<int>();
                newL.AddFirst(data);
                list[index] = newL;
            }
            else
            {
                LinkedList<int> newL = list[index];
                newL.AddLast(data);
                list[index] = newL;
            }
        }
        public bool Find(int data)
        {
            int index = HashFunc(data);
            if (list[index] == null)
            {
                return false;
            }
            else
            {
                LinkedList<int> newL = list[index];
                LinkedListNode<int> first = newL.First;
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
                LinkedListNode<int> newL = list[i].First;

                while (newL!=null)
                {
                    Console.Write($"{newL.Value} ");
                    newL = newL.Next;
                }
            }
        }
    }
}
