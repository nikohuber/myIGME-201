using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
// Niko Huber
// IGME 201
// Final Exam

namespace question1
{

    internal class Program
    {
        static void Main(string[] args)
        {

            // testing code stack
            MyStack stack = new MyStack();
            stack.Push(1);
            stack.Push(2);
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.items[0]);

            Console.WriteLine();

            // testing code queue
            MyQueue myQueue = new MyQueue();
            myQueue.Push(2);
            myQueue.Push(1);
            Console.WriteLine(myQueue.Peek());
            myQueue.Pop();
            Console.WriteLine(myQueue.items[0]);



        }
    }

    // Stack
    public class MyStack
    {
        public List<int> items = new List<int>();

        // push
        public void Push(int n)
        {
            items.Add(n);
        }

        // pop
        public int Pop()
        { 
            int temp = items[items.Count - 1];
            items.Remove(temp);
            return temp;
        }

        // peek
        public int Peek()
        {
            return items[items.Count - 1];
        }
    }

    // queue
    public class MyQueue
    {
        public List<int> items = new List<int>();

        // push
        public void Push(int n)
        {
            items.Add(n);
        }

        // pop
        public int Pop()
        {
            int temp = items[0];
            items.Remove(temp);
            return temp;
        }

        // peek
        public int Peek()
        {
            return items[0];
        }
    }
}
