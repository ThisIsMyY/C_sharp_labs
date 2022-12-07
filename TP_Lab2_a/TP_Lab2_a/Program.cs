using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Lab2_a
{
    internal class Program
    {
        public static void SystemCreating()
        {
            char[] operators = {'+', '-'};

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            string[] system = new string[n];
            double[,] matrix = new double[n,n+1];

            Console.Write("\n1.Random system.\b 2.Manual input\nChoose type of system: ");
            int systemType = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            Random rand = new Random();

            //Random system
            if (systemType == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    system[i] = "";

                    for (int j = 1; j <= n; j++)
                    {
                        string elem;
                        double nextNum = rand.Next(1, 100) * ((double)rand.Next(1, 10) / 10);

                        if (nextNum != 1)
                        {
                            elem = nextNum + "x" + j;
                        }
                        else
                        {
                            elem = "x" + j;
                        }

                        if (j != n)
                        {
                            elem += " " + operators[rand.Next(0, 2)] + " ";
                        }

                        system[i] += elem;

                        matrix[i, j - 1] = nextNum;

                    }
                    double ending = rand.Next(1, 100) * ((double)rand.Next(1, 10) / 10);
                    system[i] += " = " + ending;
                    matrix[i, n] = ending;

                    Console.WriteLine(system[i]);
                }

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j <= n; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
            }

            //Manual input
            else if(systemType == 2)
            {
                for (int i = 0; i < n; i++)
                {
                    int equationNumber = i + 1;
                    Console.WriteLine("The equation number " + equationNumber + ": ");
                    for(int j = 1; j <= n; j++)
                    {   
                        string elem;
                        Console.Write("x" + j + " = ");

                        string newSystemElement = Console.ReadLine();
                        bool isDecimal = false;

                        for(int ch = 0; ch < newSystemElement.Length; ch++)
                        {
                            if (newSystemElement[ch] == '/')
                            {
                                isDecimal = true;
                                string[] fractionElementPart = newSystemElement.Split('/');
                                matrix[i, j - 1] = Math.Round(double.Parse(fractionElementPart[0]) / double.Parse(fractionElementPart[1]), 2);
                                break;
                            }
                        }
                        if(isDecimal == false)
                        {
                            matrix[i, j - 1] = double.Parse(newSystemElement);
                        }

                        if (matrix[i,j-1] != 1)
                        {
                            elem = matrix[i, j-1] + "x" + j;
                        }
                        else
                        {
                            elem = "x" + j;
                        }

                        if (j != n)
                        {
                            elem += " " + operators[rand.Next(0, 2)] + " ";
                        }

                        system[i] += elem;
                    }
                    Console.WriteLine(system[i]);
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
            }
            double[] variables = Determinal(matrix, n);
        }

        public static double[] Determinal(double[,] matrix, int n)
        {
            /*
            
            a1, b1, c1
            a2, b2, c2
            a3, b3, c3

            */
            double[] variables = new double[n];
            double mainDet = 0;
            for (int i = 0; i < n; i++)
            {
                double subMatrixMultiply = 1;

                for (int el = 0; el < n; el++)
                {
                    subMatrixMultiply *= matrix[el + 1, el + 1];
                }

                mainDet += matrix[0, i] * subMatrixMultiply;
            }
            return variables;
        }

        static void Main(string[] args)
        {
            SystemCreating();

            Console.ReadLine();
        }
    }
}
