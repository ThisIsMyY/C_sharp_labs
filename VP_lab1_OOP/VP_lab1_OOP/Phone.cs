using System;

namespace VP_lab1_OOP
{
    //enum Processor {"a", "b", "c", "d"}
    internal class Phone : Company
    {
        string name;
        string model;
        string display;
        string processor;
        string memory;
        string price;

        /*string model;
        double display;
        bool inStock;
        int price;
        byte memory;
        DateTime date;
        Processor processor;
        Company company;*/



        public string Name { 
            get { return name; } 
            set { if (value != "") name = value; } 
        }
        public string Model {
            get { return model; }
            set { if (value != "") model = value; }
        }
        public string Display {
            get { return display; }
            set { if (value != "") display = value; } 
        }
        public string Processor {
            get { return processor; }
            set { if (value != "") processor = value; } 
        }
        public string Memory {
            get { return memory; }
            set { if (value != "") memory = value; } 
        }
        public string Price {
            get { return price; }
            set { if (value != "") price = value; } 
        }

        public Phone(string name = "Unknown", string model = "Unknown", string display = "Unknown", string processor = "Unknown", string memory = "Unknown", string price = "Unknown", string companyName = "Unknown", string companyAddress= "Unknown")
        {
            this.name = name;
            this.model = model;
            this.display = display;
            this.processor = processor;
            this.memory = memory;
            this.price = price;
            this.companyName = companyName;
            this.companyAddress = companyAddress;
        }

        public void PrintInfo(int phone_number)
        {
            Console.WriteLine("\nPhone#{0} info: \nName: {1}, \nModel: {2}, \nDisplay: {3} inches, \nProcessor: {4}, \nMemory: {5}GB, \nPrice: {6} lei, \nCompany name: {7}, \nCompany address: {8}", phone_number, name, model, display, processor, memory, price, companyName, companyAddress);
        }

        public void CreatePhoneModel()
        {
            Console.WriteLine("Enter your phone model info: ");
            Console.Write("Name: ");
            Name = Console.ReadLine();

            Console.Write("Model: ");
            Model = Console.ReadLine();

            Console.Write("Display: ");
            Display = Console.ReadLine();

            Console.Write("Processor: ");
            Processor = Console.ReadLine();

            Console.Write("Memory: ");
            Memory = Console.ReadLine();

            Console.Write("Price: ");
            Price = Console.ReadLine();

            Console.Write("Company name: ");
            CompanyName = Console.ReadLine();

            Console.Write("Company address: ");
            CompanyAddress = Console.ReadLine();
        }
    }
}