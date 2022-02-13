using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class CompareTwoArray
    {
        public void findingPattern(string Source, string Pattern)
        {
            int[] arrSource = new int[255];
            int[] arrPattern = new int[255];

            
            
            foreach (var c in Pattern)
            {
                arrPattern[(int)c] = 1;

                Console.WriteLine((int)c);
            }
            bool FLAG = true;
            int head = 0;
            int tail = Pattern.Length-1;
            for (int i = head; i < tail; i++)
            {
                arrSource[(int)Source[i]] = 1;
            }

            while (tail <= Source.Length-1)
            {
               
                arrSource[(int)Source[tail]] = 1;
                

                for (int j = 0; j < 255; j++)
                    if (arrSource[j] != arrPattern[j])
                    {
                        FLAG = false;
                        break;
                    }
                       
                    
                if (FLAG) Console.Write("matched on index " + head);
                FLAG = true;
                arrSource[(int)Source[head]] = 0;
                head++;
                tail++;
            }
            
        }
            
           
        public void main()
        {
        string a = "BACDGABCDA";
        string p = "ABCD";

        findingPattern(a, p);


        }

    }
}
