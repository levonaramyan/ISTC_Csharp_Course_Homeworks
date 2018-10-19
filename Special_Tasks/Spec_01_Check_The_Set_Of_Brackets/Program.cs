using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Spec 01: Given a string str, check whether the distribution of various types of brackets are valid in str.
//          Types of brackets: ( ) , { } , [ ] , < >
//          Ex1: "fadfa(dfsdg[gf]g)lo" ---> true
//          Ex2: "faywt{ytutu<hhf}fhfhf>hhh" ---> false 

namespace Spec_01_Check_The_Set_Of_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing a string for testing
            string test = "asd[[s{a]]d}as";

            // Printing the result
            Console.WriteLine(BracketsInStringAreNormal(test));
            Console.ReadKey();
        }

        // Returns true, if all of the brackets are stored in a string in appropriate order
        static bool BracketsInStringAreNormal(string str)
        {
            if (!CheckTheNumOfBrackets(str)) return false;

            bool isTheStringOk = true; // Will stay true, until a wrong set of brackets will be found
            char[] closed = new char[4] { ')', ']', '}', '>' }; // The types of all closing brackets

            int len = str.Length;

            // If there is a closing bracket in a string, then go and check its counterpart
            while (isTheStringOk && (str.Contains(']') || str.Contains(')') || str.Contains('}') || str.Contains('>')))
            {
                int indexCl = len; // will be the index of the first closing bracket
                char brackType = ' '; // will be the type of the first closing bracket

                // Finding the first closing bracket of any type, and gets its index
                for (int i = 0; i < 4; i++)
                {
                    int tempIndex = str.IndexOf(closed[i]);

                    if (tempIndex != -1 && tempIndex < indexCl)
                    {
                        indexCl = tempIndex;
                        brackType = closed[i];
                    }
                }

                // Checking if the previous bracket is also of the same type
                string tempString = str.Remove(indexCl);
                isTheStringOk = CheckBracketsSet(tempString, brackType);

                // If the cuurent set of brackets was ok, then get a new string wothout the content within this brackets
                if (isTheStringOk)
                {
                    int indexOp = tempString.LastIndexOf(OpenBracket(brackType)); // The index of corresponding open bracket
                    string st1 = str.Remove(indexOp); // before the open bracket
                    string st2 = (indexCl < len - 1) ? str.Substring(indexCl + 1) : ""; // after the closing bracket
                    str = $"{st1}{st2}"; // the new string, without the content of the previus set of brackets 
                    len = str.Length; // recalculating the length of a string
                }
            }

            return isTheStringOk;
        }

        // Returns true, if in str, the last open bracket corresponds to the input type of closing bracket
        static bool CheckBracketsSet(string str, char type)
        {
            char t = OpenBracket(type); // the corresponding open bracket
            bool closedNormal = true; // will stay true, while the bracket t is the last open bracket in str
            char[] bracks = new char[4] { '(', '[', '{', '<' }; // all types of open brackets
            int iBrack = str.LastIndexOf(t); // the index of the last open bracket t
            if (iBrack == -1) return false; // if no bracket t found, then finding a missmatch and return false

            // Checking one by one the indexes of other open brackets, with respect to iBrack
            foreach (char c in bracks)
            {
                if (c != t && str.LastIndexOf(c) > iBrack)
                {
                    closedNormal = false;
                    break;
                }
            }
            return closedNormal;
        }

        // Returns true if the number of open and closing brackets are equal for each type
        static bool CheckTheNumOfBrackets(string str)
        {
            bool theNumIsOK = true;
            char[] opened = new char[4] { '(', '[', '{', '<' };
            int[] opNum = new int[4];
            int[] closNum = new int[4];
            char[] closed = new char[4] { ')', ']', '}', '>' };

            // calculating the number of various brackets in str 
            foreach (char c in str)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (opened[i] == c) opNum[i]++;
                    if (closed[i] == c) closNum[i]++;
                }
            }

            // checking if the number of each type of open and closing brackest are equal
            for (int i = 0; i < 4; i++)
            {
                if (opNum[i] != closNum[i])
                {
                    theNumIsOK = false;
                    break;
                }
            }

            return theNumIsOK;
        }

        // Returns the corresponding open bracket of input closing bracket
        static char OpenBracket(char type)
        {
            char t1 = ' ';

            switch (type)
            {
                case ')':
                    t1 = '(';
                    break;
                case ']':
                    t1 = '[';
                    break;
                case '}':
                    t1 = '{';
                    break;
                case '>':
                    t1 = '<';
                    break;
            }

            return t1;
        }
    }
}
