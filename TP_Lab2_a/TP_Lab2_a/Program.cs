using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Lab2_a
{
    internal class Program
    {
        public static void SystemCreatingAndCalculation()
        {
            Console.Write("Enter N (2 - 3): ");
            int n = int.Parse(Console.ReadLine());
            if(n < 2) n = 2;
            else if(n > 3) n = 3;

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
                        double nextNum = rand.Next(-100, 100) * ((double)rand.Next(1, 10) / 10);

                        if (nextNum != 1)
                        {
                            elem = nextNum + "x" + j;
                        }
                        else
                        {
                            elem = "x" + j;
                        }

                        //operator adding
                        if (j > 1)
                        {
                            if(nextNum < 0)
                            {
                                elem = " - " + (nextNum * -1).ToString();
                            }
                            else
                            {
                                elem = " + " + elem;
                            }
                        }

                        system[i] += elem;

                        matrix[i, j - 1] = nextNum;

                    }

                    double ending = rand.Next(-100, 100) * ((double)rand.Next(1, 10) / 10);
                    system[i] += " = " + ending;
                    matrix[i, n] = ending;
                }

                SystemDisplay(system, matrix, n);
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

                        //operator adding
                        if (j > 1)
                        {
                            if (j > 1)
                            {
                                if (matrix[i, j - 1] < 0)
                                {
                                    elem = " - " + (matrix[i, j - 1] * -1).ToString();
                                }
                                else
                                {
                                    elem = " + " + elem;
                                }
                            }
                        }

                        system[i] += elem;
                    }

                    Console.Write("last elem  = ");
                    string lastSystemElement = Console.ReadLine();
                    bool isDecimalNumber = false;

                    for (int ch = 0; ch < lastSystemElement.Length; ch++)
                    {
                        if (lastSystemElement[ch] == '/')
                        {
                            isDecimalNumber = true;
                            string[] fractionElemPart = lastSystemElement.Split('/');
                            system[i] += " = " + Math.Round(double.Parse(fractionElemPart[0]) / double.Parse(fractionElemPart[1]), 2);
                            matrix[i, n] = Math.Round(double.Parse(fractionElemPart[0]) / double.Parse(fractionElemPart[1]), 2);
                            break;
                        }
                    }
                    if (isDecimalNumber == false)
                    {
                        system[i] += " = " + lastSystemElement;
                        matrix[i, n] = double.Parse(lastSystemElement);
                    }
                }
                SystemDisplay(system, matrix, n);
            }

            //system variables calculation
            Determinal(matrix, n);
        }

        public static void SystemDisplay(string[] system, double[,] matrix, int n)
        {
            //system output
            Console.WriteLine("\nSystem:-----------------------\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(system[i]);
            }

            //matrix output
            Console.WriteLine("\nMatrix:-----------------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
        }

        public static void Determinal(double[,] matrix, int n)
        {
            double[] variables = new double[n];
            NumarRational mainDet;
            if (n == 2)
            {
                NumarRational a1 = new NumarRational(matrix[0, 0]);
                NumarRational a2 = new NumarRational(matrix[1, 0]);

                NumarRational b1 = new NumarRational(matrix[0, 1]);
                NumarRational b2 = new NumarRational(matrix[1, 1]);

                NumarRational n1 = new NumarRational(matrix[0, n]);
                NumarRational n2 = new NumarRational(matrix[1, n]);

                mainDet = a1 * b2 - b1 * a2;
                NumarRational detX1 = (n1 * b2 - b1 * n2) / mainDet;
                NumarRational detX2 = (a1 * n2 - n1 * a2) / mainDet;

                Console.WriteLine("\n\nVariables value:-----------------------\n");
                Console.WriteLine("x1 = " + Math.Round(detX1.NumValue, 3));
                Console.WriteLine("x2 = " + Math.Round(detX2.NumValue, 3));
            }
            /*
            
            a1, n, c1
            a2, n, c2
            a3, n, c3

            */
            else if (n == 3)
            {
                NumarRational a1 = new NumarRational(matrix[0, 0]);
                NumarRational a2 = new NumarRational(matrix[1, 0]);
                NumarRational a3 = new NumarRational(matrix[2, 0]);

                NumarRational b1 = new NumarRational(matrix[0, 1]);
                NumarRational b2 = new NumarRational(matrix[1, 1]);
                NumarRational b3 = new NumarRational(matrix[2, 1]);

                NumarRational c1 = new NumarRational(matrix[0, 2]);
                NumarRational c2 = new NumarRational(matrix[1, 2]);
                NumarRational c3 = new NumarRational(matrix[2, 2]);

                NumarRational n1 = new NumarRational(matrix[0, n]);
                NumarRational n2 = new NumarRational(matrix[1, n]);
                NumarRational n3 = new NumarRational(matrix[2, n]);

                NumarRational detX1;
                NumarRational detX2;
                NumarRational detX3;

                mainDet = a1 * (b2 * c3 - c2 * b3);
                mainDet = mainDet - b1 * (a2 * c3 - c2 * a3);
                mainDet = mainDet + c1 * (a2 * b3 - b2 * a3);

                detX1 = n1 * (b2 * c3 - c2 * b3);
                detX1 = detX1 - b1 * (n2 * c3 - c2 * n3);
                detX1 = detX1 + c1 * (n2 * b3 - b2 * n3);

                detX2 = b1 * (n2 * c3 - c2 * n3);
                detX2 = detX2 - n1 * (a2 * c3 - c2 * a3);
                detX2 = detX2 + c1 * (a2 * n3 - n2 * a3);

                detX3 = a1 * (b2 * n3 - n2 * b3);
                detX3 = detX3 - b1 * (a2 * n3 - n2 * a3);
                detX3 = detX3 + n1 * (a2 * b3 - b2 * a3);


                Console.WriteLine("\n\nVariables value:-----------------------\n");
                Console.WriteLine("x1 = " + detX1.NumValue);
                Console.WriteLine("x2 = " + detX2.NumValue);
                Console.WriteLine("x3 = " + detX3.NumValue);
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                SystemCreatingAndCalculation();
                Console.Write("\nAgain? (Yes = 1, No = 0) ");
                if (Console.ReadLine() != "1")
                {
                    Console.WriteLine("Good bye!");
                    break;
                }
                else Console.Clear();
            }

            Console.ReadLine();
        }
    }
}
