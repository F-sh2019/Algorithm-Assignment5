using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class MyStack
    {


        
            public Queue q1 = new Queue();
            public Queue q2 = new Queue();

            public void Push(int x) => q1.Enqueue(x);


            public int Pop()
            {
                if (q1.Count == 0)
                
                    return - 1;
                
                while (q1.Count > 1)
                {
                    q2.Enqueue(q1.Dequeue());

                }

                int res = (int)q1.Dequeue();

                Queue Temp = q1;
                q1 = q2;
                q2 = Temp;
                return res;



            }


            public int Size() => q1.Count;


                public int Top()
                {
                    if (q1.Count == 0)
                        return -1;
                    while (q1.Count > 1)
                    {
                        q2.Enqueue(q1.Dequeue());
                    }
                    int res = (int)q1.Dequeue();
                    q2.Enqueue(res);
                    Queue temp = q1;
                    q1 = q2;
                    q2 = temp;
                    return res;
                }

        public  void Main()
        {
            MyStack s = new MyStack();
            s.Push(1);
            Console.WriteLine("Size of Stack: " + s.Size() + "\tTop : " + s.Top());
            s.Push(7);
            Console.WriteLine("Size of Stack: " + s.Size() + "\tTop : " + s.Top());
            s.Push(9);
            Console.WriteLine("Size of Stack: " + s.Size() + "\tTop : " + s.Top());

            s.Pop();
            Console.WriteLine("Size of Stack: " + s.Size() + "\tTop : " + s.Top());
            s.Pop();
            Console.WriteLine("Size of Stack: " + s.Size() + "\tTop : " + s.Top());

            s.Push(5);
            Console.WriteLine("Size of Stack: " + s.Size() + "\tTop : " + s.Top());
        }

    }
    
}
