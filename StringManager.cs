using System;
using System.Collections.Generic;
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
            return ASCII.ToString();
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
