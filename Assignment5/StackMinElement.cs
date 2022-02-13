using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    public class StackMinElement
	{

        
		public Stack s;
		public int MinValue;

		
		public StackMinElement()
		{
			s = new Stack();
		}

		
		public void GetMin()
		{
			
			if (s.Count == 0)
				Console.WriteLine("Stack is empty");

			
			else
				Console.WriteLine("Minimum Element in the " +
								" stack is: " + MinValue);
		}

		
		public void Peek()
		{
			if (s.Count == 0)
			{
				Console.WriteLine("Stack is empty ");
				return;
			}

			int t = (int)s.Peek();

			Console.Write("Top Most Element is: ");

			
			if (t < MinValue)
				Console.WriteLine(MinValue);
			else
				Console.WriteLine(t);
		}

		
		public void Pop()
		{
			if (s.Count == 0)
			{
				Console.WriteLine("Stack is empty");
				return;
			}

			Console.Write("Top Most Element Removed: ");
			int t = (int)s.Pop();

			
			if (t < MinValue)
			{
				Console.WriteLine(MinValue);
				MinValue = 2 * MinValue - t;
			}

			else
				Console.WriteLine(t);
		}

		
		public void Push(int x)
		{
			if (s.Count == 0)
			{
				MinValue = x;
				s.Push(x);
				Console.WriteLine("Number Inserted: " + x);
				return;
			}

			
			if (x < MinValue)
			{
				s.Push(2 * x - MinValue);
				MinValue = x;
			}

			else
				s.Push(x);

			Console.WriteLine("Number Inserted: " + x);
		}
	


	
		public  void main()
		{
			StackMinElement s = new StackMinElement();
			s.Push(4);
			s.Push(6);
			s.GetMin();
			s.Push(2);
			s.Push(3);
			s.GetMin();
			s.Push(0);
			s.Push(1);
			s.Push(-1);
			s.Pop();
			s.GetMin();
			s.Pop();
			s.Peek();
		}
	


}
}
