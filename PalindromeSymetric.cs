using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string inputNum = Console.ReadLine();  // this is an string array

                if (inputNum == "END")
                {
                    break;
                }

                int lengthArr = inputNum.Length;   //  1125211 // 1221
                bool isTrue = true; // acept the number is polindrom-symetric

                for (int i = 0; i < lengthArr / 2; i++)
                {
                     int currSymbol = inputNum[i]; // curr symbol from the string

                     //if (lengthArr % 2 != 0)  // odd number Length                     
                         if (currSymbol != inputNum[inputNum.Length - 1 - i])
                         {
                             isTrue = false;
                             break;
                         }  
                         // no need to make check is the array Length is even or odd /
                      //else //(lengthArr % 2 == 0 )  // even number Length arra to check                     
                     // the loop steps are absolutei the same for odd Length and Even Length array!!!
                }

                if (isTrue)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
