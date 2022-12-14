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
            mystring string4 = new MyString("hello world. See ya! ".ToCharArray());
            Console.WriteLine("\nstring1: " + string1.Result);
            Console.WriteLine("\nstring2: " + string2.Result);
            Console.WriteLine("\nstring3: " + string3.Result);
            Console.WriteLine("\nstring4: " + string4.Result);



            //funtion-indexator
            Console.WriteLine("\n\n\nFuntion-indexer:\n----------------------");
            Console.WriteLine("{0}[1]: {1}", string2.Result, string2.Result[1]);

            //get length
            Console.WriteLine("\n\n\nGet string length:\n----------------------");
            Console.WriteLine("string length of {0}: {1}", string1.Result, string1.Length);

            //operator +
            mystring newString = string1 + string4;
            Console.WriteLine("\n\n\nOperator + :\n----------------------");
            Console.WriteLine("{0} + {1} = {2}", string1.Result, string4.Result, newString.Result);

            //1)Join
            char[][] stringArray = { "string1".ToCharArray(), "string2".ToCharArray(), "string3".ToCharArray(), "string4".ToCharArray(), "string5".ToCharArray(), "string6".ToCharArray() };
            mystring string5 = new MyString(MyString.Join(", ".ToCharArray(), stringArray));
            mystring string6 = new MyString(MyString.Join(',', stringArray));
            Console.WriteLine("\n\n\nJoin():\n----------------------");
            Console.WriteLine("\nstring5: " + string5.Result);
            Console.WriteLine("\nstring6: " + string6.Result);



            //2)Concat
            mystring string7 = new MyString(MyString.Concat("str1".ToCharArray(), "str2".ToCharArray(), "str3".ToCharArray(), "str4".ToCharArray()));
            Console.WriteLine("\n\n\nConcat():\n----------------------");
            Console.WriteLine("string7: " + string7.Result);



            //3)Spaces counter
            Console.WriteLine("\n\n\nSpacesCounter():\n----------------------");
            Console.WriteLine("count of spaces in \"{0}\": {1} ", string4.Result, string4.SpacesCounter());



            //4)Equals
            Console.WriteLine("\n\n\nEquals():\n----------------------");
            Console.WriteLine("\nis {0} equal to \"abcdefghij\"? {1}", string3.Result, string3.Equals("abcdefghij"));
            Console.WriteLine("\nis {0} equal to \"bcdefgh\"? {1}", string3.Result, string3.Equals("bcdefgh"));
            Console.WriteLine("\nare strings \"string1\" and \"string2\" equals? " + MyString.Equals("string1", "string2"));



            //5)Contains
            Console.WriteLine("\n\n\nContains():\n----------------------");
            Console.WriteLine("is string \"{0}\" contains \"{1}\"? {2} ", string4.Result, "hello world", string4.Contains("hello world".ToCharArray()));



            //6)StartsWith
            Console.WriteLine("\n\n\nStartsWith():\n----------------------");
            Console.WriteLine("is string \" " + string4.Result + "\" starts with substring \"hello\"? " + string4.StartsWith("hello".ToCharArray()));

            //7)EndsWith
            Console.WriteLine("\n\n\nEndsWith():\n----------------------");
            Console.WriteLine("is string \" "+string4.Result+ "\" ends with substring \"See ya!\"? " + string4.EndsWith("See ya!".ToCharArray()));



            //8)IndexOf
            Console.WriteLine("\n\n\nIndexOf():\n----------------------");
            if (string4.IndexOf("See".ToCharArray()) != -1)
            {
                Console.WriteLine("first occurance of substring \"See\" in string " + string4.Result + " has index: " + string4.IndexOf("See".ToCharArray()));
            }
            else
            {
                Console.WriteLine("string " + string4.Result + "has not substring \"See\"");
            }

            //9)LastIndexOf
            Console.WriteLine("\n\n\nLastIndexOf():\n----------------------");
            if (string4.LastIndexOf("See ya".ToCharArray()) != -1)
            {
                Console.WriteLine("last occurance of substring \"See ya\" in string " + string4.Result + " has index: " + string4.LastIndexOf("See".ToCharArray()));
            }
            else
            {
                Console.WriteLine("string " + string4.Result + "has not substring \"See ya\"");
            }



            //10)Split
            Console.WriteLine("\n\n\nSplit():\n----------------------");
            Console.Write(string4.Result + " => ");
            Console.WriteLine(MyString.Join("; ".ToCharArray(), string4.Split(' ')));

            //11)Trim
            MyString string8 = new MyString("abcdefg hij klmnop".ToCharArray());
            Console.WriteLine("\n\n\nTrim():\n----------------------");
            Console.Write("New string: ");
            Console.WriteLine(string8.Trim('a', 'f', ' '));
            Console.Write("Old string: ");
            Console.WriteLine(string8.Result);

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
            Console.WriteLine("insert \"hello\" into \"" + string8.Result + "\": ");
            Console.WriteLine(string8.Insert(18, " hello ".ToCharArray()));

            //15)Remove
            Console.WriteLine("\n\n\nRemove():\n----------------------");
            Console.Write("remove all elements from index 3 in \"" + string8.Result + "\": ");
            Console.WriteLine(string8.Remove(3));
            Console.Write("remove 3 next elements from index 3 in \"" + string8.Result + "\": ");
            Console.WriteLine(string8.Remove(3, 3));

            Console.ReadLine();
        }
    }
}
