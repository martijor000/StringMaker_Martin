using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringMaker_Martin
{
    class StringManager
    {
        Stack<char> stringStack = new Stack<char>();


        public StringManager()
        {
            
        }

        public string Reverse(string s)
        {
            char[] test = s.ToCharArray();
            return StackString(test);
        }

        public string Reverse(string s, bool b)
        {
            char[] test = s.ToCharArray();
            return StackString(test);
        }

        public bool Symmetric(string s)
        {
            if(s == Reverse(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string test = "Dan";
            int ASCII = 0;

            foreach(char c in test)
            {
                ASCII += (int)c;
            }

            //Need to fix this and find a way to split the int into an array
            int[] ASCIIArr = ASCII.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();


            string[] numWords = new string [ASCIIArr.Length];

            for(int i = 0; i < ASCIIArr.Length; i++)
            {
                Console.WriteLine(ASCIIArr[i]);
                numWords[i] = numberSwitch(ASCIIArr[i]);
            }

            string words = string.Join(" ", numWords);
            
            return words;
        }

        // Case will check the value of the number being inputed and returns the string value of the number
        public string numberSwitch(int number)
        {
            string num = "";
            switch (number)
            {
                case 1:
                    num = "One";
                    break;
                case 2:
                    num = "Two";
                    break;
                case 3:
                    num = "Three";
                    break;
                case 4:
                    num = "Four";
                    break;
                case 5:
                    num = "Five";
                    break;
                case 6:
                    num = "Six";
                    break;
                case 7:
                    num = "Seven";
                    break;
                case 8:
                    num = "Eight";
                    break;
                case 9:
                    num = "Nine";
                    break;
            }
            return num;
        }

        public override bool Equals(object obj)
        {
            if(obj is string)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string StackString(char[] charArray)
        {

            for (int i = 0; i < charArray.Length; i++)
            {
                stringStack.Push(charArray[i]);
            }

            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = stringStack.Pop();
            }
            string stri = new string(charArray);

            return stri;
        }

        private string CapitalizeString(string cap)
        {
            char[] charA = cap.ToLower().ToCharArray();
            for (int i = 0; i < charA.Length; i++)
            {
                if(charA[i] == 0)
                {
                    charA[i] = charA[i];
                }
            }
                return "";
        }
    }
}
