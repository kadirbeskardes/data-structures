using System;
using System.Collections;
using System.Collections.Generic;

namespace MyHash
{
    public class MyHashLLLetter
    {
        static private LinkedList<string>[] list = new LinkedList<string>[26];
        static private int aHashCode = (int)('a');
        private int HashFunc(string data)
        {
            string tempData;
            tempData= data.ToLower();
            int value = 0;
            value = aHashCode + (byte)tempData[0];
            return value % aHashCode;
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
                string valueTemp;
                string dataTemp;
                LinkedList<string> newL = list[index];
                LinkedListNode<string> first = newL.First;
                while (first != null)
                {
                    valueTemp= first.Value.ToLower();
                    dataTemp= data.ToLower();
                    if (valueTemp.Equals(dataTemp))
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
                if (list[i]==null)
                {
                    Console.Write($"There is not a name start with '{(char)(aHashCode+i)}'");
                    continue;
                }
                LinkedListNode<string> tempL= list[i].First;
                Console.Write($"These name start with '{(char)(aHashCode + i)}': ");
                while (tempL!=null)
                {
                    Console.Write($"'{tempL.Value}' ");
                    tempL = tempL.Next;
                }
            }
        }
    }
}