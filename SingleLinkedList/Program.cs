using System;

namespace SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class SList
    {
        SList Head = null;
        SList Last = null;
        SList temp = null;
        public int data;
        public SList next;

        public SList FintTheBiggest()
        {
            temp = Head;
            SList biggest = new SList();
            while (temp != null)
            {
                if (temp.data > biggest.data)
                {
                    biggest = temp;
                }
            }
            return biggest;
        }
        public void CreateUntil(int lowLimit, int upLimit)
        {
            for (int i = lowLimit; i < upLimit; i++)
            {
                SList temp = new SList();
                temp.data = i;
                if (Head == null)
                {
                    Head = temp;
                    Last = temp;
                }
                else
                {
                    Last.next = temp;
                    Last = temp;
                }

            }
            Console.WriteLine("until {0} from{1}", upLimit, lowLimit);
            temp = Head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = Head;
        }
        public void addFirst(int myData)
        {
            temp = new SList();
            temp.data = myData;
            if (Head == null)
            {
                temp.next = null;
                Head = temp;
                Console.WriteLine("The list is empty. {0} is added to list as Head.", myData);
            }
            else
            {
                temp.next = Head;
                Head = temp;
                Console.WriteLine("{0} is added to first of list.", myData);
            }
        }
        public void addLast(int myData)
        {
            temp = Head;
            SList bl = new SList();
            bl.data = myData;
            bl.next = null;
            if (Head == null)
            {
                Head = bl;
                Console.WriteLine("The list is empty. {0} is added to list as Head.", myData);
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = bl;
                Console.WriteLine("{0} is added to last of list.", myData);
            }


        }
        public void addAfter(int myData, int index)
        {
            if (Head == null)
            {
                SList blo = new SList();
                blo.data = myData;
                Head = blo;
                Console.WriteLine("The list is empty. {0} is added to list as Head.", myData);
            }
            else
            {
                bool found = false;
                if (Head.data == index)
                {
                    SList blo = new SList();
                    blo.data = myData;
                    blo.next = null;
                    Head.next = blo;
                    found = true;
                }
                else
                {
                    temp = Head;
                    while (temp.next != null)
                    {
                        if (temp.data == index)
                        {
                            SList blo = new SList();
                            blo.data = myData;
                            blo.next = temp.next;
                            temp.next = blo;
                            found = true;
                            break;
                        }
                        temp = temp.next;
                    }

                }
                if (found)
                {
                    Console.WriteLine("{0} is added to after of {1}.", myData, index);
                }
                else
                {
                    Console.WriteLine("{0} is not in list. {1} couldn't added list.", index, myData);
                }
            }


        }
        public void addBefore(int myData, int index)
        {
            if (Head == null)
            {
                SList blo = new SList();
                blo.data = myData;
                Head = blo;
                Console.WriteLine("The list is empty. {0} is added to list as Head.", myData);
            }
            else
            {
                bool found = false;

                if (Head.data == index)
                {
                    SList blo = new SList();
                    blo.data = myData;
                    blo.next = Head;
                    Head = blo;
                    found = true;
                }
                else
                {
                    temp = Head;
                    while (temp.next != null)
                    {
                        if (temp.next.data == index)
                        {

                            SList blo = new SList();
                            blo.data = myData;
                            blo.next = temp.next;
                            temp.next = blo;
                            found = true;
                            break;
                        }
                        temp = temp.next;
                    }
                }

                if (found)
                {
                    Console.WriteLine("{0} is added to after of {1}.", myData, index);
                }
                else
                {
                    Console.WriteLine("{0} is not in list. {1} couldn't added list.", index, myData);
                }
            }
        }
        public void deleteThis(int myData)
        {
            temp = Head;
            bool found = false;
            while (temp != null)
            {
                if (temp.next.data == myData)
                {
                    temp.next = temp.next.next;
                    found = true;
                    break;
                }
                else
                {
                    temp = temp.next;
                }
            }
            if (found == true)
            {
                Console.WriteLine("{0} is deleted from list.", myData);
            }
            else
            {
                Console.WriteLine("{0} couldn't found in list and couldn't deleted.", myData);
            }
        }
        public void Write()
        {
            temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine("All data has been displayed");
        }
    }
}