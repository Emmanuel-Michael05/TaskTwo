using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo.DataStructures
{
    public class Stack<T>
    {
        private SinglyLinkedList<T> list = new();

        public bool IsEmpty()
        {
            return list.Size() == 0;
        }

        public void Push(T item)
        {
            list.Add(item);
        } 

        public T Pop()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is empty.");
            var topIndex = list.Size() - 1;
            var topItem = Peek();
            list.Remove(topItem);
            return topItem;
        }

        public T Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is empty.");
            return list.Get(list.Size() - 1);
        }

        public int Size()
        {
           return list.Size();
        }  
    }
}
