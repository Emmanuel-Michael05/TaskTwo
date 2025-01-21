using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo.DataStructures
{
        public class SinglyLinkedList<T>
        {
            private class Node
            {
                public T Data;
                public Node? Next;

                public Node(T data)
                {
                    Data = data;
                    Next = null;
                }
            }

            private Node? head;
            private int count;

            public int Size() 
            { 
                return count;
            } 

            public void Add(T item)
            {
                var newNode = new Node(item);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    var current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
                count++;
            }

            public bool Remove(T item)
            {
                if (head == null) return false;

                if (head.Data!.Equals(item))
                {
                    head = head.Next;
                    count--;
                    return true;
                }

                var current = head;
                while (current.Next != null && !current.Next.Data!.Equals(item))
                {
                    current = current.Next;
                }

                if (current.Next != null)
                {
                    current.Next = current.Next.Next;
                    count--;
                    return true;
                }
                return false;
            }

            public bool Check(T item)
            {
                var current = head;
                while (current != null)
                {
                    if (current.Data!.Equals(item)) return true;
                    current = current.Next;
                }
                return false;
            }

            public int Index(T item)
            {
                var current = head;
                int index = 0;
                while (current != null)
                {
                    if (EqualityComparer<T>.Default.Equals(current.Data, item)) return index;
                    current = current.Next;
                    index++;
                }
                return -1;
            }
            public T Get(int index)
            {
                if (index < 0 || index >= count)
                    throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

                var current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current!.Next;
                }

                return current!.Data; 
            }


    }

}
