using System;

namespace TP_lab3
{
    using mystring = MyString;
    internal class Program
    {
        static void Main(string[] args)
        {
            //string creating
            mystring string1 = new MyString('a', 6);
            mystring string2 = new MyString(new char[]{'a','b'});
            mystring string3 = new MyString(new char[]{'a','b','c','d','e','f','g','h','i','j'}, 1, 8);
            mystring string4 = new MyString("hello world. See ya!");

            //Join method
            string[] stringArray = { "string1", "string2", "string3", "string4", "string5", "string6"};
            mystring string5 = new MyString(MyString.Join(", ", stringArray));
            mystring string6 = new MyString(MyString.Join(',', stringArray));

            //Concat method
            mystring string7 = new MyString(MyString.Concat("str1", "str2", "str3", "str4"));

            //strings output
            Console.WriteLine("\nstring1: " + string1.Result);
            Console.WriteLine("\nstring2: " + string2.Result);
            Console.WriteLine("\nstring3: " + string3.Result);
            Console.WriteLine("\nstring4: " + string4.Result);
            Console.WriteLine("\nstring5: " + string5.Result);
            Console.WriteLine("\nstring6: " + string6.Result);
            Console.WriteLine("\nstring7: " + string7.Result);

            //get length
            Console.WriteLine("\nstring length of string1: " + string1.Length);

            //Spaces counter method
            Console.WriteLine("\ncount of spaces in string5: " + string4.SpacesCounter());

            //Equals method
            Console.WriteLine("\nis string3 equal to \"abcdefghij\"? " + string3.Equals("abcdefghij"));
            Console.WriteLine("\nis string3 equal to \"bcdefgh\"? " + string3.Equals("bcdefgh"));
            Console.WriteLine("\nare two string equals? " + MyString.Equals("string1", "string2"));

            //Contains method
            Console.WriteLine("\nis current string contains substring? " + string4.Contains("hello world"));

            //StartsWith method
            Console.WriteLine("\nis string \" " + string4.Result + "\" starts with substring \"hello\"? " + string4.StartsWith("hello"));

            //EndsWith method
            Console.WriteLine("\nis string \" "+string4.Result+ "\" ends with substring \"See ya!\"? " + string4.EndsWith("See ya!"));

            //IndexOf
            if(string4.IndexOf("See") != -1)
            {
                Console.WriteLine("\nfirst occurance of substring in current string has index: " + string4.IndexOf("See"));
            }
            else
            {
                Console.WriteLine("\ncurrent string has not such a substring");
            }

            if (string4.LastIndexOf("See") != -1)
            {
                Console.WriteLine("\nfirst occurance of substring in current string has index: " + string4.LastIndexOf("See"));
            }
            else
            {
                Console.WriteLine("\ncurrent string has not such a substring");
            }

            //funtion-indexator
            Console.WriteLine("\nstring2[1]: " + string2.Result[1]);

            Console.ReadLine();
        }
    }
}
