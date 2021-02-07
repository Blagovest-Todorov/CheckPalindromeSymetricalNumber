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

                bool endResult = IsNumPalindrome(inputNum);
                Console.WriteLine(endResult.ToString().ToLower());
            }

            static bool IsNumPalindrome(string inputNum)
            {
                int lengthArr = inputNum.Length;   //  1125211 // 1221
                bool isTrue = true; // acept the number is polindrom-symetric

                for (int i = 0; i < lengthArr / 2; i++)
                {
                    int currSymbol = inputNum[i]; // curr symbol from the string

                    if (currSymbol != inputNum[inputNum.Length - 1 - i])
                    {
                        isTrue = false;
                        break;
                    }
                }

                return isTrue;
            }
        }
    }
}
