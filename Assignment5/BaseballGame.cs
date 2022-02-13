using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class BaseballGame
    {

        public int Calpoints(string[] ops)
        {
            //Stack s = new Stack();
            int[] Record = new int[1000];
            int i = -1;

            foreach (var s in ops)
            {
                if (s == "+" && Record.Length >= 2)
                {
                    i++;
                    Record[i] = Record[i - 1] + Record[i - 2];
                }
                else if (s == "C" && Record.Length >= 1)
                {
                    Record[i] = 0;
                    i--;
                }
                else if (s == "D" && Record.Length >= 1)
                {
                    i++;
                    Record[i] = Record[i - 1] * 2;
                }
                else
                {
                    i++;
                    Record[i] = int.Parse(s);
                }

            }
            int sum = 0;
            for (int j = 0; j < Record.Length; j++)
            {
                sum = Record[j] + sum;
            }
            return sum;
        }

    


    public void main()
    {
        string[] s = { "5", "2", "C", "D", "+" };

        int d = Calpoints(s);
        Console.Write(d);




    }


}


}
