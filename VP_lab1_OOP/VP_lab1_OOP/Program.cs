using System;
using System.IO;

namespace VP_lab1_OOP
{
    internal class Program
    {
        public static void PhoneInfoGenerator(string[,] phoneInfo, out string phone_name, out string phone_model, out string phone_display, out string phone_processor, out string phone_memory, out string phone_price, out string phone_companyName, out string phone_companyAddress)
        {
            Random rand = new Random();

            phone_name = phoneInfo[0, rand.Next(0, 7)];
            phone_model = phoneInfo[1, rand.Next(0, 7)];
            phone_display = phoneInfo[2, rand.Next(0, 7)];
            phone_processor = phoneInfo[3, rand.Next(0, 7)];
            phone_memory = phoneInfo[4, rand.Next(0, 7)];
            phone_price = phoneInfo[5, rand.Next(0, 7)];
            phone_companyName = phoneInfo[6, rand.Next(0, 7)];
            phone_companyAddress = phoneInfo[7, rand.Next(0, 7)];
        }

        public static void PhoneShow(int objects_number, string path)
        {
            for (int i = 1; i < objects_number; i++)
            {
                FileInfo phone_txtFile = new FileInfo(@"E:\C#\VP_lab1_OOP\objects\phone" + i + ".txt");
                if (phone_txtFile.Exists)
                {
                    string fileText = File.ReadAllText(path + "phone" + i + ".txt");
                    Console.WriteLine($"\nPhone#{i}\n" + fileText);
                }
            }
        }
        public static void PhoneDelete(int objects_number, string path)
        {
            Console.WriteLine("Our phone models:");
            for (int i = 1; i < objects_number; i++)
            {
                FileInfo phone_txtFile = new FileInfo(@"E:\C#\VP_lab1_OOP\objects\phone" + i + ".txt");
                if (phone_txtFile.Exists)
                {
                    string fileText = File.ReadAllText(path + "phone" + i + ".txt");
                    Console.WriteLine($"\nPhone#{i}\n" + fileText);
                }
            }
            while (true)
            {
                Console.WriteLine("Which phone model do you prefer to delete?");
                if (int.TryParse(Console.ReadLine(), out int file_number))
                {
                    FileInfo phoneModelFile = new FileInfo(path + "phone" + file_number + ".txt");
                    phoneModelFile.Delete();
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong value! Try again...");
                }
            }
        }
        static void Main(string[] args)
        {

            string[,] phoneInfo =
            {
                {
                    "Aboba 2000",
                    "Galaxy A6",
                    "Aboba 3000",
                    "Kwantor",
                    "Kwantor 2.0",
                    "Jesus 3.0",
                    "Nokia 3310",
                    "Nokia 6000"
                },
                {
                    "Gram",
                    "Galaxy",
                    "Aboba",
                    "Matrix",
                    "Matrix 2.0",
                    "Terra",
                    "Nokia",
                    "Konia"
                },
                {
                    "3",
                    "3.5",
                    "4",
                    "4.5",
                    "5",
                    "5.5",
                    "6",
                    "6.5"
                },
                {
                    "Aboba",
                    "Kwantory",
                    "Exenos",
                    "Tor",
                    "Lighting",
                    "MixFight",
                    "Rocky",
                    "Delta"
                },
                {
                    "2",
                    "4",
                    "8",
                    "16",
                    "32",
                    "64",
                    "128",
                    "256"
                },
                {
                    "1000",
                    "2000",
                    "4000",
                    "6000",
                    "8000",
                    "10000",
                    "12000",
                    "15000"
                },
                {
                   "The Rock",
                   "Cubix",
                   "ElectroHeart",
                   "Dodli",
                   "Roots",
                   "Xiaomi",
                   "Apple",
                   "Samsung"
                },
                {
                    "St.Kwantor str. 19",
                    "Aboba str. 69",
                    "Rucoy str. 13/3",
                    "Nokia str. 007",
                    "Alfa Omega str. unit 3, floor 4",
                    "Germany-USSR 1945 str. unit 2",
                    "20th Century Fox str. 31/35",
                    "St.Nurse str. 3/9"
                }
            };

            string phone_name;
            string phone_model;
            string phone_display;
            string phone_processor;
            string phone_memory;
            string phone_price;
            string phone_companyName;
            string phone_companyAddress;
            Phone phone;

            string path = @"E:\C#\VP_lab1_OOP\objects\";
            DirectoryInfo objects_directory = new DirectoryInfo(path);
            if (!objects_directory.Exists)
                objects_directory.Create();

            for (int i = 1; i <= 8; i++)
            {
                PhoneInfoGenerator(phoneInfo, out phone_name, out phone_model, out phone_display, out phone_processor, out phone_memory, out phone_price, out phone_companyName, out phone_companyAddress);

                phone = new Phone(phone_name, phone_model, phone_display, phone_processor, phone_memory, phone_price, phone_companyName, phone_companyAddress);

                FileInfo phone_txtFile = new FileInfo(@"E:\C#\VP_lab1_OOP\objects\phone" + i + ".txt");
                if (!phone_txtFile.Exists)
                {
                    File.AppendAllText(path + "phone"+i+".txt", $"Name: {phone.Name}\nModel: {phone.Model}\nDisplay: {phone.Display}\nProcessor: {phone.Processor}\nMemory: {phone.Memory}\nPrice: {phone.Price}\nCompany name: {phone.CompanyName}\nCompany address: {phone.CompanyAddress}");
                }
            }
            int objects_number = objects_directory.GetFiles().Length + 1;

            Console.WriteLine("Hello. What do you want to do?");
            bool programClose = false;
            while (!programClose)
            {
                Console.WriteLine("\n1.Make an order.\n2.Create new phone model.\n3.Phone model editing.\n4.Delete phone model.\n5.Exit.\n");
                Console.Write("Choose your fate: ");
                if (int.TryParse(Console.ReadLine(), out int firstMenu_action))
                {
                    switch (firstMenu_action)
                    {
                        //show objects
                        case 1:
                            bool continue_cycle = true;
                            while (continue_cycle)
                            {
                                Console.WriteLine("Our phone models:");
                                PhoneShow(objects_number, path);

                                Console.WriteLine("\n1.Choose phone model.\n2.Back to main menu.\n");
                                if (int.TryParse(Console.ReadLine(), out int secondMenu_action))
                                {
                                    bool continue_phoneNumber_choose = true;
                                    while (continue_phoneNumber_choose)
                                    {
                                        switch (secondMenu_action)
                                        {
                                            case 1:
                                                Console.Write("Type phone model number: ");
                                                if (int.TryParse(Console.ReadLine(), out int phone_number))
                                                {
                                                    Console.WriteLine("Your choose is number " + phone_number + ". Your order will be processed soon.");
                                                    continue_phoneNumber_choose = false;
                                                    continue_cycle = false;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Wrong value. Try again...");
                                                }
                                                break;
                                            case 2:
                                                continue_phoneNumber_choose = false;
                                                continue_cycle = false;
                                                break;
                                            default:
                                                Console.WriteLine("Wrong value. Try again...");
                                                continue_phoneNumber_choose = false;
                                                break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Wrong value. Try again...");
                                }
                            }
                            break;

                        //object creating
                        case 2:
                            while (true)
                            {
                                Console.WriteLine("\n1.Random object.\n1.Own data.\nWhat method do you prefer: ");
                                if (int.TryParse(Console.ReadLine(), out int method)){
                                    if (method == 1)
                                    {
                                        PhoneInfoGenerator(phoneInfo, out phone_name, out phone_model, out phone_display, out phone_processor, out phone_memory, out phone_price, out phone_companyName, out phone_companyAddress);
                                        phone = new Phone(phone_name, phone_model, phone_display, phone_processor, phone_memory, phone_price, phone_companyName, phone_companyAddress);

                                        Console.WriteLine("\nYour phone model has been successfully created. \n\nInfo about model:");
                                        phone.PrintInfo(objects_number);

                                        FileInfo new_phone_txtFile = new FileInfo(@"E:\C#\VP_lab1_OOP\objects\phone" + objects_number + ".txt");
                                        if (!new_phone_txtFile.Exists)
                                        {
                                            File.AppendAllText(path + "phone" + objects_number + ".txt", $"Name: {phone.Name}\nModel: {phone.Model}\nDisplay: {phone.Display}\nProcessor: {phone.Processor}\nMemory: {phone.Memory}\nPrice: {phone.Price}\nCompany name: {phone.CompanyName}\nCompany address: {phone.CompanyAddress}");
                                            objects_number++;
                                        }
                                        break;
                                    }
                                    else if (method == 2)
                                    {
                                        phone = new Phone();
                                        phone.CreatePhoneModel();

                                        Console.WriteLine("\nYour phone model has been successfully created. \n\nInfo about model:");
                                        phone.PrintInfo(objects_number);

                                        FileInfo new_phone_txtFile = new FileInfo(@"E:\C#\VP_lab1_OOP\objects\phone" + objects_number + ".txt");
                                        if (!new_phone_txtFile.Exists)
                                        {
                                            File.AppendAllText(path + "phone" + objects_number + ".txt", $"Name: {phone.Name}\nModel: {phone.Model}\nDisplay: {phone.Display}\nProcessor: {phone.Processor}\nMemory: {phone.Memory}\nPrice: {phone.Price}\nCompany name: {phone.CompanyName}\nCompany address: {phone.CompanyAddress}");
                                            objects_number++;
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Wrong value! Try again...");
                                    }
                                }
                            }
                            break;

                        //phone model editing
                        case 3:
                            while (true)
                            {
                                PhoneShow(objects_number, path);
                                Console.Write("\nEnter model number you want to edit: ");
                                if (int.TryParse(Console.ReadLine(),out int phone_model_for_editing))
                                {
                                    string file_path = path + "phone" + phone_model_for_editing + ".txt";
                                    string[] phone_model_file_text = File.ReadAllLines(file_path);
                                    Console.WriteLine("\nPhone#" + phone_model_for_editing + " info:\n" + string.Join("\n", phone_model_file_text)+"\n");
                                    Console.Write("1)Name. 2)Model. 3)Display. 4)Processor. 5)Memory. 6)Price. 7)CompanyName. 8CompanyAddress.\n Enter number of element you want to change: ");
                                    if (int.TryParse(Console.ReadLine(), out int info_element_number))
                                    {
                                        string field_name = phone_model_file_text[info_element_number-1].Split(':')[0];
                                        Console.Write("Type new {0} info: ", field_name);
                                        phone_model_file_text[info_element_number - 1] = field_name + ": " + Console.ReadLine();
                                        File.WriteAllLines(file_path, phone_model_file_text);
                                        break;
                                    }
                                    else Console.WriteLine("Wrong value. Try again...");
                                }
                            }
                            break;
                        //delete phone model
                        case 4:
                            PhoneDelete(objects_number, path);
                            break;
                        //exit from program
                        case 5:
                            Console.WriteLine("Good bye...");
                            programClose = true;
                            break;
                        default:
                            Console.WriteLine("Wrong value. Try again...");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong value. Try again...");
                }
            }
        }
    }
}
