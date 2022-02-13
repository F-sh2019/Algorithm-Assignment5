using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class StackMinEle
    {

        Stack<stackEle> s;

        /** initialize your data structure here. */
        public StackMinEle()
        {
            this.s = new Stack<stackEle>();
        }
        public void push(int x)
        {
            if (s.Count == 0)
            {
                this.s.Push(new stackEle(x, x));
            }
            else
            {

                int min = Math.Min(Convert.ToInt32(this.s.Peek().min), x);
                this.s.Push(new stackEle(x, min));
            }
        }
        public int pop()
        {


            return this.s.Pop().val;
        }
        public int top()
        {

            return this.s.Peek().val;
        }
        public int getMin()
        {

            return this.s.Peek().min;
        }




        public void Main()
        {
            StackMinEle s = new StackMinEle();
            s.push(-1);
            s.push(10);
            s.push(-4);
            s.push(0);
            Console.WriteLine(s.getMin());
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
            Console.WriteLine(s.getMin());


        }


    }
}
