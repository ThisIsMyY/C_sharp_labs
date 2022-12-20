using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Lab4
{
    internal class Program
    {
        public static void FieldGenerating()
        {
            Console.WriteLine("-----------");
            Console.SetCursorPosition(0, 17);
            Console.WriteLine("-----------");
            Console.SetCursorPosition(0, 0);

            for (int i = 0; i < 18; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
                Console.SetCursorPosition(11, i);
                Console.Write("|");
            }
            Console.SetCursorPosition(0, 1);
        }
        public static void FieldUpdate()
        {
            for (int i = 0; i < 16; i++)
            {
                if(i> 0) Console.WriteLine();
                for (int j = 0; j < 10; j++)
                {
                    Console.SetCursorPosition(j+1, i+1);
                    Console.Write("0");
                }
            }
        }
        public static void Play()
        {
            for(int i = 1; i <= 16; i++)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.F10)
                {
                    break;
                }
                Console.SetCursorPosition(1, 1);
                FieldUpdate();
                Console.SetCursorPosition(4, i);
                Console.Write("♦♦♦♦");
                System.Threading.Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            FieldGenerating();
            Play();

            Console.ReadLine();
        }
    }
}
