using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class MatchStrings
    {

        public int matchlist(List<string> CodeList, List<string> ShoppingList)
        {
            if (CodeList.Count == 0 && ShoppingList.Count > 0)
                return 1;
            if (ShoppingList.Count == 0)
                return 0;

            bool isMatched = false;
            bool IsOrder = false;
            int i = 0;
            int lastmatched = 0;
           string[] ShoppingList1= new string[ShoppingList.Count];

            foreach (var U in ShoppingList)
            {
                ShoppingList1[i] = U;
                i++;
            }
            
            while (IsOrder == false && ShoppingList.Count > 0)
                foreach (var SecCode in CodeList)
                {

                    while (!isMatched)
                    {
                       

                        for (i= lastmatched; i< ShoppingList1.Length;i++)
                        {


                            if (SecCode != "anything" || SecCode != ShoppingList1[i])
                            {
                                ShoppingList.RemoveAt(0);
                                lastmatched++;
                                if (IsOrder) IsOrder = false;
                                isMatched = false;
                                //Console.WriteLine("shoppingList is " );
                                //foreach(var U in ShoppingList)
                                //    Console.Write(U +"," );

                               // Console.WriteLine("the match Status is " + isMatched);
                            }

                            if (SecCode == "anthing" || SecCode == ShoppingList1[i])
                            {
                                lastmatched++;
                                isMatched = true;
                                //Console.WriteLine("shoppingList is " + ShoppingList1[i]);
                                //foreach (var U in ShoppingList)
                                //    Console.Write(U + ",");
                              //  Console.WriteLine("the match Status is " + isMatched);
                            }

                        }


                    }
                }
            if (isMatched)
                return 1;
            return 0;
        }



        public void main()

        {

            List<string> Card = new List<string> { "potato", "apple", "potatp", "apple", "mango", "benana", "Orange", "benana" };

            List<string> CodeList = new List<string> {  "apple","mango", "anything", "Orange", "benana" };
            Console.WriteLine("aa");
            int a = matchlist(CodeList, Card);
            Console.WriteLine("result is "+a);


        }



    }
}
