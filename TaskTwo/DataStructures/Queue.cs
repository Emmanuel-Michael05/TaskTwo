using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo.DataStructures
{
    public class Queue<T>
    {
        private SinglyLinkedList<T> list = new();

        public bool IsEmpty()
        {
           return list.Size() == 0;
        }

        public void Enqueue(T item)
        {
            list.Add(item);
        }

        public T Dequeue()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is empty.");
            var frontItem = Peek();
            list.Remove(frontItem);
            return frontItem;
        }

        public T Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is empty.");
            return list.Get(0)!; 
        }

        public int Size() 
        {
          return  list.Size();
        } 
    }
}
