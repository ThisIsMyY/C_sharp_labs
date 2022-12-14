using System;
using System.Collections.Generic;

namespace TP_lab3
{
    internal class MyString
    {
        private char[] result;
        private int length = 0;
        public string Result { get => new string(result); }
        public int Length { get => result.Length; }

        //funtion-indexator
        //public char this[int index] { get { return this[index]; } }


        //Constructors
        public MyString(char ch, int repeatNumber)
        {
            result = new char[repeatNumber];
            for(int i = 0; i < repeatNumber; i++)
            {
                result[i] = ch;
                length++;
            }
        }
        public MyString(char[] chArr)
        {
            result = new char[chArr.Length];
            for (int ch = 0; ch < chArr.Length; ch++)
            {
                result[ch] = chArr[ch];
                length++;
            }
        }
        public MyString(char[] chArr, int startIndex, int endIndex)
        {
            result = new char[endIndex - startIndex + 1];
            for (int i = startIndex; i < endIndex; i++)
            {
                result[i] = chArr[i];
                length++;
            }
        }
        public MyString(char[] str1, char[] str2)
        {
            result = new char[str1.Length + str2.Length];
            for (int i = 0; i < str1.Length; i++)
            {
                result[i] = str1[i];
            }
            for (int ch = str1.Length, i = 0; i < str2.Length; i++, ch++)
            {
                result[ch] = str2[i];
            }
        }

        //operators

        public static MyString operator +(MyString str1, MyString str2)
        {
            return new MyString(str1.result, str2.result);
        }

        //methods

        //string joining
        public static char[] Join(char[] separator, char[][] array)
        {
            List<char> separatedArray = new List<char>();
            if(array.Length > 1)
            {
                int ch = 0;
                for (int s = 0; s < array.GetLength(0) - 1; s++)
                {
                    for(int arrCh = 0; arrCh < array[s].Length; arrCh++, ch++)
                    {
                        separatedArray.Add(array[s][arrCh]);
                    }

                    for (int sep = 0; sep < separator.Length; sep++)
                    {
                        separatedArray.Add(separator[sep]);
                    }
                }
                for (int arrCh = 0; ch < array[array.GetLength(0) - 1].Length; arrCh++, ch++)
                {
                    separatedArray[ch] = array[array.GetLength(0) - 1][arrCh];
                }
            }
            return separatedArray.ToArray();
        }
        public static char[] Join(char separator, char[][] array)
        {
            List<char> separatedArray = new List<char>();
            if (array.Length > 1)
            {
                int ch = 0;
                for (int s = 0; s < array.GetLength(0) - 1; s++)
                {
                    for (int arrCh = 0; arrCh < array[s].Length; arrCh++, ch++)
                    {
                        separatedArray.Add(array[s][arrCh]);
                    }
                    separatedArray.Add(separator);
                }
                for (int arrCh = 0; ch < array[array.GetLength(0) - 1].Length; arrCh++, ch++)
                {
                    separatedArray.Add(array[array.GetLength(0) - 1][arrCh]);
                }
            }
            return separatedArray.ToArray();
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
        public bool Equals(char[] value)
        {
            if (result.ToString() == value.ToString())
            {
                return true;
            }
            else return false;
        }
        public static bool Equals(char[] value1, char[] value2)
        {
            if (value1.ToString() == value2.ToString())
            {
                return true;
            }
            else return false;
        }

        //Concat
        public static char[] Concat(params char[][] values)
        {
            List<char> concatString = new List<char>();
            for(int i = 0; i < values.GetLength(0); i++)
            {
                for(int j = 0; j < values[i].Length; j++)
                {
                    concatString.Add(values[i][j]);
                }
            }
            return concatString.ToArray();
        }

        //Contains
        public bool Contains(char[] value)
        {
            char[] substring = new char[value.Length];
            for (int i = 0; i < length; i++)
            {
                if (i <= value.Length - 1)
                {
                    if (result[i] == value[i])
                    {
                        substring[i] = value[i];
                        if (substring.ToString() == value.ToString())
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
        public bool StartsWith(char[] value)
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
        public bool EndsWith(char[] value)
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
        public int IndexOf(char[] value)
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
        public int LastIndexOf(char[] value)
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
        public char[][] Split(char separator)
        {
            List<char> substring = new List<char>();
            List<char[]> substringsList = new List<char[]>();
            int index = 0;

            for (int ch = 0; ch < length; ch++)
            {
                if (ch == length - 1)
                {
                    if (substring.Count > 0)
                    {
                        substring.Add(result[ch]);
                        substringsList.Add(substring.ToArray());
                        substring.Clear();
                    }
                }
                else if (result[ch] != separator)
                {
                    substring.Add(result[ch]);
                }
                else
                {
                    if (substring.Count > 0)
                    {
                        substringsList.Add(substring.ToArray());
                        substring.Clear();
                        index++;
                    }
                }
            }
            return substringsList.ToArray();
        }

        //Trim
        public char[] Trim()
        {
            int? startIndex = null;
            int? endIndex = null;
            List<char> str = new List<char>();

            for (int ch = 0; ch < length; ch++)
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
                    str.Add(result[index]);
                }
            }
            return str.ToArray();
        }

        public char[] Trim(params char[] trimChars)
        {
            List<char> str = new List<char>();
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
                    str.Add(result[ch]);
                }
            }
            return str.ToArray();
        }

        //PadLeft
        public char[] PadLeft(int totalWidth)
        {
            List<char> spaces = new List<char>();

            for(int i = 0; i < totalWidth; i++)
            {
                spaces.Add(' ');
            }
            for(int i = 0; i < length; i++)
            {
                spaces.Add(result[i]);
            }
            return spaces.ToArray();
        }

        public char[] PadLeft(int totalWidth, char paddingChar)
        {
            List<char> spaces = new List<char>();

            for (int i = 0; i < totalWidth; i++)
            {
                spaces.Add(paddingChar);
            }
            for (int i = 0; i < length; i++)
            {
                spaces.Add(result[i]);
            }
            return spaces.ToArray();
        }

        //PadRight
        public char[] PadRight(int totalWidth)
        {
            List<char> spaces = new List<char>();

            for (int i = 0; i < length; i++)
            {
                spaces.Add(result[i]);
            }
            for (int i = 0; i < totalWidth; i++)
            {
                spaces.Add(' ');
            }
            return spaces.ToArray();
        }

        public char[] PadRight(int totalWidth, char paddingChar)
        {
            List<char> spaces = new List<char>();

            for (int i = 0; i < length; i++)
            {
                spaces.Add(result[i]);
            }
            for (int i = 0; i < totalWidth; i++)
            {
                spaces.Add(paddingChar);
            }
            return spaces.ToArray();
        }

        //Insert
        public char[] Insert(int startIndex, char[] value)
        {
            char[] str = new char[length + value.Length];
            if(startIndex == length)
            {
                for(int i = 0; i < length; i++)
                {
                    str[i] = result[i];
                }
                for (int i = length, ch = 0; i < str.Length; i++, ch++)
                {
                    str[i] = value[ch];
                }
                return str;
            }
            for(int ch = 0; ch < length; ch++)
            {
                if(ch != startIndex)
                {
                    str[ch] = result[ch];
                }
                else
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        str[ch] = value[i];
                    }
                    str[ch] = result[ch];
                }
            }
            return str;
        }

        //Remove
        public char[] Remove(int startIndex)
        {
            List<char> str = new List<char>();
            for(int ch = 0; ch < startIndex; ch++)
            {
                str.Add(result[ch]);
            }
            return str.ToArray();
        }

        public char[] Remove(int startIndex, int count)
        {
            List<char> str = new List<char>();
            for (int ch = 0; ch < startIndex; ch++)
            {
                str.Add(result[ch]);
            }
            for (int ch = startIndex+3; ch < length; ch++)
            {
                str.Add(result[ch]);
            }
            return str.ToArray();
        }
    }
}
