using System;

namespace TP_lab3
{
    using mystring = MyString;
    internal class Program
    {
        static void Main(string[] args)
        {
            //string creating
            Console.WriteLine("Constructors:\n----------------------");
            mystring string1 = new MyString('a', 6);
            mystring string2 = new MyString(new char[]{'a','b'});
            mystring string3 = new MyString(new char[]{'a','b','c','d','e','f','g','h','i','j'}, 1, 8);
            mystring string4 = new MyString("hello world. See ya! ");
            Console.WriteLine("\nstring1: " + string1.Result);
            Console.WriteLine("\nstring2: " + string2.Result);
            Console.WriteLine("\nstring3: " + string3.Result);
            Console.WriteLine("\nstring4: " + string4.Result);



            //funtion-indexator
            Console.WriteLine("\n\n\nFuntion-indexer:\n----------------------");
            Console.WriteLine("{0}[1]: {1}", string2, string2.Result[1]);

            //get length
            Console.WriteLine("\n\n\nGet string length:\n----------------------");
            Console.WriteLine("string length of {0}: {1}", string1, string1.Length);

            string1.Result = string2.Result + string3.Result;
            Console.WriteLine("\n\n\nAddition operator:\n----------------------");
            Console.WriteLine("{0} + {1} = {2}", string1, string2, string1.Result);


            //1)Join
            string[] stringArray = { "string1", "string2", "string3", "string4", "string5", "string6"};
            mystring string5 = new MyString(MyString.Join(", ", stringArray));
            mystring string6 = new MyString(MyString.Join(',', stringArray));
            Console.WriteLine("\n\n\nJoin():\n----------------------");
            Console.WriteLine("\nstring5: " + string5.Result);
            Console.WriteLine("\nstring6: " + string6.Result);



            //2)Concat
            mystring string7 = new MyString(MyString.Concat("str1", "str2", "str3", "str4"));
            Console.WriteLine("\n\n\nConcat():\n----------------------");
            Console.WriteLine("string7: " + string7.Result);



            //3)Spaces counter
            Console.WriteLine("\n\n\nSpacesCounter():\n----------------------");
            Console.WriteLine("count of spaces in {0}: {1} ", string4, string4.SpacesCounter());



            //4)Equals
            Console.WriteLine("\n\n\nEquals():\n----------------------");
            Console.WriteLine("\nis {0} equal to \"abcdefghij\"? ", string3, string3.Equals("abcdefghij"));
            Console.WriteLine("\nis {0} equal to \"bcdefgh\"? ", string3, string3.Equals("bcdefgh"));
            Console.WriteLine("\nare two string equals? " + MyString.Equals("string1", "string2"));



            //5)Contains
            Console.WriteLine("\n\n\nContains():\n----------------------");
            Console.WriteLine("is string {0} contains {1}? ", string4, string4.Contains("hello world"));



            //6)StartsWith
            Console.WriteLine("\n\n\nStartsWith():\n----------------------");
            Console.WriteLine("is string \" " + string4.Result + "\" starts with substring \"hello\"? " + string4.StartsWith("hello"));

            //7)EndsWith
            Console.WriteLine("\n\n\nEndsWith():\n----------------------");
            Console.WriteLine("is string \" "+string4.Result+ "\" ends with substring \"See ya!\"? " + string4.EndsWith("See ya!"));



            //8)IndexOf
            Console.WriteLine("\n\n\nIndexOf():\n----------------------");
            if (string4.IndexOf("See") != -1)
            {
                Console.WriteLine("first occurance of substring in string " + string4 + " has index: " + string4.IndexOf("See"));
            }
            else
            {
                Console.WriteLine("string " + string4 + "has not substring \"See\"");
            }

            //9)LastIndexOf
            Console.WriteLine("\n\n\nLastIndexOf():\n----------------------");
            if (string4.LastIndexOf("See ya") != -1)
            {
                Console.WriteLine("last occurance of substring in string "+ string4 +" has index: " + string4.LastIndexOf("See"));
            }
            else
            {
                Console.WriteLine("string " + string4 + "has not substring \"See ya\"");
            }



            //10)Split
            Console.WriteLine("\n\n\nSplit():\n----------------------");
            Console.WriteLine(MyString.Join(" ", string4.Split(' ', '.')));

            //11)Trim
            MyString string8 = new MyString("abcdefg hij klmnop");
            Console.WriteLine("\n\n\nTrim():\n----------------------");
            Console.WriteLine("New string: " + string8.Trim('a', 'f', ' '));
            Console.WriteLine("Old string: " + string8.Result);

            //12)PadLeft
            Console.WriteLine("\n\n\nPadLeft():\n----------------------");
            Console.WriteLine(string8.PadLeft(8));
            Console.WriteLine(string8.PadLeft(8, 'o'));

            //13)PadRight
            Console.WriteLine("\n\n\nPadRight():\n----------------------");
            Console.WriteLine(string8.PadRight(8));
            Console.WriteLine(string8.PadRight(8, 'a'));

            //14)Insert
            Console.WriteLine("\n\n\nInsert():\n----------------------");
            Console.WriteLine(string8.Insert(18, " hello "));

            //15)Remove
            Console.WriteLine("\n\n\nInsert():\n----------------------");
            Console.WriteLine(string8.Remove(3));
            Console.WriteLine(string8.Remove(3, 3));

            Console.ReadLine();
        }
    }
}
