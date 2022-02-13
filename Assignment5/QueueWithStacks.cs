using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    public  class QueueWithStacks
    {


        public Stack<int> stack1=new Stack<int>();
        public Stack<int> stack2 = new Stack<int>();

        public void enQueue(int new_data)

        {
            stack1.Push(new_data);

        }

         public int deQueue()
        {
            if (stack1.Count == 0 && stack2.Count == 0)
            {
                Console.WriteLine("Q is Empty");
                Environment.Exit(0);
            }

            if (stack2.Count == 0)
            {
                while (stack1.Count != 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }
            int x= stack2.Pop();
            return  x;
        }
   

    // Driver code
    public  void Main()
    {
        QueueWithStacks q = new QueueWithStacks();
        q.enQueue(1);
        q.enQueue(2);
        q.enQueue(3);

        Console.Write(q.deQueue() + " ");
        Console.Write(q.deQueue() + " ");
        Console.Write(q.deQueue());
    }
    }
}
