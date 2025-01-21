using System;
using CustomQueue = TaskTwo.DataStructures.Queue<int>;
using CustomStack = TaskTwo.DataStructures.Stack<int>;
using CustomLinkedList = TaskTwo.DataStructures.SinglyLinkedList<int>;

namespace TaskTwo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("---- LinkedList Demonstration ----");
            var linkedList = new CustomLinkedList();
            linkedList.Add(10);
            linkedList.Add(20);
            linkedList.Add(30);
            Console.WriteLine($"List size: {linkedList.Size()}");
            Console.WriteLine($"List contains 20: {linkedList.Check(20)}");
            Console.WriteLine($"Index of 30: {linkedList.Index(30)}");
            Console.WriteLine($"Remove 20: {linkedList.Remove(20)}");
            Console.WriteLine($"List size: {linkedList.Size()}");

            Console.WriteLine("\n---- Stack Demonstration ----");
            var stack = new CustomStack();
            stack.Push(100);
            stack.Push(200);
            Console.WriteLine($"Stack Peek: {stack.Peek()}");
            Console.WriteLine($"Stack Pop: {stack.Pop()}");
            Console.WriteLine($"Stack size: {stack.Size()}");

            Console.WriteLine("\n---- Queue Demonstration ----");
            var queue = new CustomQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Console.WriteLine($"Queue Peek: {queue.Peek()}");
            Console.WriteLine($"Queue Dequeue: {queue.Dequeue()}");
            Console.WriteLine($"Queue size: {queue.Size()}");
        }
    }
}
