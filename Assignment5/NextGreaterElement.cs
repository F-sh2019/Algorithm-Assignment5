using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    public static class NextGreaterElement
    {


       
           
            static void printNGE(int[] arr, int n)
            {
                Stack<int> s = new Stack<int>();

                int[] arr1 = new int[n];

                
                for (int i = n - 1; i >= 0; i--)
                {
                    
                    while (s.Count != 0 && s.Peek() <= arr[i])
                        s.Pop();

                   
                    if (s.Count == 0)
                        arr1[i] = -1;
                    else
                        arr1[i] = s.Peek();

                    s.Push(arr[i]);
                }

                for (int i = 0; i < n; i++)
                    Console.WriteLine(arr[i] + " ---> " +
                                      arr1[i]);
            }

          
            public static void main()
            {
                int[] arr = { 11, 13, 7, 21 };
                int n = arr.Length;
                printNGE(arr, n);
            }
        }
    
}
