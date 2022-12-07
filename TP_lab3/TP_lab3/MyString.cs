using System;
using System.Collections.Generic;

namespace TP_lab3
{
    internal class MyString
    {
        private string result = "";
        private int length = 0;
        public string Result { get { return result; } set { result = value; } }
        public int Length { get { return length; } set { length = value; } }

        //funtion-indexator
        public char this[int index] { get { return this[index]; } }


        //Constructors
        public MyString(char ch, int repeatNumber)
        {
            for(int i = 0; i < repeatNumber; i++)
            {
                result += ch;
                length++;
            }
        }
        public MyString(char[] chArr)
        {
            foreach (char ch in chArr)
            {
                result += ch;
                length++;
            }
        }
        public MyString(char[] chArr, int startIndex, int endIndex)
        {
            for(int i = startIndex; i < endIndex; i++)
            {
                result += chArr[i];
                length++;
            }
        }
        public MyString(string str1, string str2)
        {
            result = str1 + str2;
            foreach (char c in result)
            {
                length++;
            }
        }

        public MyString(string str)
        {
            result = str;
            foreach (char c in result)
            {
                length++;
            }
        }

        //operators

        public static MyString operator +(MyString str1, MyString str2)
        {
            return new MyString(str1.result, str2.result);
        }

        //methods

        //string joining
        public static string Join(string separator, string[] array)
        {
            string separatedArray = "";
            if(array.Length > 1)
            {
                for (int s = 0; s < array.Length - 1; s++)
                {
                    separatedArray += array[s] + separator;
                }
            }
            separatedArray += array[array.Length - 1];
            return separatedArray;
        }
        public static string Join(char separator, string[] array)
        {
            string separatedArray = "";
            if (array.Length > 1)
            {
                for (int s = 0; s < array.Length - 1; s++)
                {
                    separatedArray += array[s] + separator;
                }
            }
            separatedArray += array[array.Length - 1];
            return separatedArray;
        }

        //Spaces counter
        public int SpacesCounter()
        {
            int spacesCount = 0;
            foreach (char ch in result)
            {
                if(ch == ' ')
                {
                    spacesCount++;
                }
            }
            return spacesCount;
        }

        //check for equality
        public bool Equals(string value)
        {
            if (result == value)
            {
                return true;
            }
            else return false;
        }
        public static bool Equals(string value1, string value2)
        {
            if (value1 == value2)
            {
                return true;
            }
            else return false;
        }

        //Concat
        public static string Concat(params string[] values)
        {
            string concatString = "";
            foreach(string str in values)
            {
                concatString += str;
            }
            return concatString;
        }

        //Contains
        public bool Contains(string value)
        {
            string substring = "";
            for (int i = 0; i < length; i++)
            {
                if (i <= value.Length - 1)
                {
                    if (result[i] == value[i])
                    {
                        substring += value[i];
                        if (substring == value)
                        {
                            return true;
                        }
                    }
                }
                else return false;
            }
            return false;
        }

        //StartsWith
        public bool StartsWith(string value)
        {
            if(length < value.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (result[i] != value[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //EndsWith
        public bool EndsWith(string value)
        {
            if (length < value.Length)
            {
                return false;
            }
            else
            {
                for (int i = value.Length-1, j = 1; i > 0; i--, j++)
                {
                    if (result[length-j] != value[i])
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }

        //IndexOf
        public int IndexOf(char value)
        {
            for(int ch = 0; ch < length; ch++)
            {
                if(result[ch] == value)
                {
                    return ch;
                }
            }
            return -1;
        }
        public int IndexOf(string value)
        {
            int index = -1;
            int count = 0;
            for (int ch = 0; ch < length; ch++)
            {
                for(int j = 0; j < value.Length; j++)
                {
                    //Console.WriteLine("ch: " + ch + ", j: " + j + ", index: " + index + ", count: " + count + ", first: " + result[ch] + ", second: " + value[j]);
                    if (result[ch+j] == value[j])
                    {
                        count++;
                        if (count == 1)
                        {
                            index = ch;
                        }

                        if (count == value.Length)
                        {
                            return index;
                        }
                    }
                    else
                    {
                        count = 0;
                        break;
                    }
                }
            }
            return -1;
        }

        //LasrIndexOf
        public int LastIndexOf(char value)
        {
            for (int ch = length-1; ch > 0; ch--)
            {
                if (result[ch] == value)
                {
                    return ch;
                }
            }
            return -1;
        }
        public int LastIndexOf(string value)
        {
            int index = -1;
            int count = 0;
            for (int ch = length - 1; ch > value.Length; ch--)
            {
                for (int j = value.Length - 1; j >= 0; j--)
                {
                    //Console.WriteLine("ch: " + ch + ", j: " + j + ", index: " + index + ", count: " + count + ", first: " + result[ch - (value.Length - j)] + ", second: " + value[j]);
                    if (result[ch - (value.Length - j)] == value[j])
                    {
                        count++;
                        if (count == value.Length)
                        {
                            index = ch - (value.Length - j);
                        }

                        if (count == value.Length)
                        {
                            return index;
                        }
                    }
                    else
                    {
                        count = 0;
                        break;
                    }
                }
            }
            return -1;
        }

        //Split
        public string[] Split(char separator)
        {
            string substring = "";
            int index = 0;
            List<string> substringsList = new List<string>();
            for (int ch = 0; ch < length; ch++)
            {
                if (ch == length - 1)
                {
                    if (substring != "")
                    {
                        substring += result[ch];
                        substringsList.Add(substring);
                        substring = "";
                    }
                }
                else if (result[ch] != separator)
                {
                    substring += result[ch];
                }
                else
                {
                    if (substring != "")
                    {
                        substringsList.Add(substring);
                        substring = "";
                        index++;
                    }
                }
            }
            return substringsList.ToArray();
        }

        public string[] Split(params char[] separators)
        {
            string substring = "";
            int index = 0;
            bool isSeparator = false;
            List<string> substringsList = new List<string>();
            for (int ch = 0; ch < length; ch++)
            {
                if (ch == length - 1)
                {
                    if (substring != "")
                    {
                        substring += result[ch];
                        substringsList.Add(substring);
                        substring = "";
                    }
                }
                else
                {
                    int i = 0;
                    while(i < separators.Length)
                    {
                        if(result[ch] == separators[i])
                        {
                            isSeparator = true;
                            break;
                        }
                        else
                        {
                            isSeparator = false;
                        }
                        i++;
                    }
                    if(isSeparator == false)
                    {
                        substring += result[ch];
                    }
                }
                if(isSeparator == true)
                {
                    if (substring != "")
                    {
                        substringsList.Add(substring);
                        substring = "";
                        index++;
                    }
                }
            }
            return substringsList.ToArray();
        }

        //Trim
        public string Trim()
        {
            int? startIndex = null;
            int? endIndex = null;
            string str = "";
            for(int ch = 0; ch < length; ch++)
            {
                if(startIndex == null)
                {
                    if (result[ch] != ' ')
                    {
                        startIndex = ch;
                    }
                }
                if (endIndex == null)
                {
                    if (result[length - ch - 1] != ' ')
                    {
                        endIndex = length - ch - 1;
                    }
                }
            }
            if(startIndex != null && endIndex != null)
            {
                for (int index = (int)startIndex; index <= endIndex; index++)
                {
                    str += result[index];
                }
            }
            return str;
        }

        public string Trim(params char[] trimChars)
        {
            string str = "";
            for (int ch = 0; ch < length; ch++)
            {
                bool isTrimChar = false;
                for(int trimChar = 0; trimChar < trimChars.Length; trimChar++)
                {
                    if(result[ch] == trimChars[trimChar])
                    {
                        isTrimChar = true;
                        break;
                    }
                }
                if (isTrimChar == false)
                {
                    str += result[ch];
                }
            }
            return str;
        }

        //PadLeft
        public string PadLeft(int totalWidth)
        {
            string spaces = "";
            for(int i = 0; i < totalWidth; i++)
            {
                spaces += ' ';
            }
            return spaces + result;
        }

        public string PadLeft(int totalWidth, char paddingChar)
        {
            string paddingChars = "";
            for (int i = 0; i < totalWidth; i++)
            {
                paddingChars += paddingChar;
            }
            return paddingChars + result;
        }

        //PadRight
        public string PadRight(int totalWidth)
        {
            string spaces = "";
            for (int i = 0; i < totalWidth; i++)
            {
                spaces += ' ';
            }
            return result + spaces;
        }

        public string PadRight(int totalWidth, char paddingChar)
        {
            string paddingChars = "";
            for (int i = 0; i < totalWidth; i++)
            {
                paddingChars += paddingChar;
            }
            return result + paddingChars;
        }

        //Insert
        public string Insert(int startIndex, string value)
        {
            string str = "";
            if(startIndex == length)
            {
               return result + value;
            }
            for(int ch = 0; ch < length; ch++)
            {
                if(ch != startIndex)
                {
                    str += result[ch];
                }
                else
                {
                    str += value;
                    str += result[ch];
                }
            }
            return str;
        }

        //Remove
        public string Remove(int startIndex)
        {
            string str = "";
            for(int ch = 0; ch < startIndex; ch++)
            {
                str += result[ch];
            }
            return str;
        }

        public string Remove(int startIndex, int count)
        {
            string str = "";
            for (int ch = 0; ch < startIndex; ch++)
            {
                str += result[ch];
            }
            for (int ch = startIndex+3; ch < length; ch++)
            {
                str += result[ch];
            }
            return str;
        }
    }
}
