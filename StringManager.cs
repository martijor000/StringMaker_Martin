using System;
using System.Collections.Generic;

namespace StringMaker_Martin
{
    class StringManager
    {
        private Stack<char> stringStack = new Stack<char>();
        private string _overString;
        private int _ASCII = 0;
        private string _results = "";
        private string num = "";

        public StringManager() : this("")
        {

        }

        public StringManager(string overString)
        {
            _overString = overString;
        }

        public string Reverse(string reverseString)
        {
            return StackString(reverseString.ToCharArray());
        }

        public string Reverse(string reverseString, bool keepCap)
        {
            return CapitalizeString(CapitalIndex(reverseString.ToCharArray()), StackString(reverseString.ToCharArray()).ToLower().ToCharArray());
        }

        public bool Symmetric(string s)
        {
            if (s == Reverse(s))
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
            if(_overString == "")
            {
                return "Negative One";
            }

            foreach (char c in _overString)
            {
                _ASCII += (int)c;
            }

            for (int i = 0; i < _ASCII.ToString().ToCharArray().Length; i++)
            {
                _results += numberSwitch(_ASCII.ToString().ToCharArray()[i].ToString()) + " ";
            }
            return _results;
        }

        private string numberSwitch(string number)
        {
            switch (number)
            {
                case "0":
                    num = "Zero";
                    break;
                case "1":
                    num = "One";
                    break;
                case "2":
                    num = "Two";
                    break;
                case "3":
                    num = "Three";
                    break;
                case "4":
                    num = "Four";
                    break;
                case "5":
                    num = "Five";
                    break;
                case "6":
                    num = "Six";
                    break;
                case "7":
                    num = "Seven";
                    break;
                case "8":
                    num = "Eight";
                    break;
                case "9":
                    num = "Nine";
                    break;
            }
            return num;
        }

        public override bool Equals(object obj)
        {
            if (obj is string)
            {
                if(obj.ToString() == _overString)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

        private int [] CapitalIndex(char[] charArray)
        {
             int[] upperIndexes = new int [charArray.Length];

            for(int i=0; i < charArray.Length; i++)
            {
                if (Char.IsUpper(charArray[i]))
                {
                    upperIndexes[i] = 1;
                }
            }
            return upperIndexes;
        }

        private string CapitalizeString(int[] capIndex, char[] capitalize)
        {
            for (int i = 0; i < capIndex.Length; i++)
            {
                if (capIndex[i] == 1)
                {
                    capitalize[i] = Convert.ToChar(capitalize[i].ToString().ToUpper());
                }
            }

            string stri = new string(capitalize);

            return stri;
        }
    }
}
