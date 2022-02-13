using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class MatchingCharacters
    {
        public bool Isvalid(string v)
        {
            Stack d = new Stack();
           
            
            foreach (var ch in v)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    d.Push(ch);


                }
                else
                {   if (d.Count > 0)
                    {
                        char m = (char)d.Peek();
                        
                        if( (m=='{' && ch=='}') || (m == '(' && ch == ')')|| (m == '[' && ch == ']'))


                            d.Pop();



                    }
                }
            
            }

            if (d.Count == 0)
                return true;

            return false;

       }


        public void main()
        {
          string  s = "{}[]()";
        
          Console.WriteLine(Isvalid(s));
        }
    
    
    }
}
