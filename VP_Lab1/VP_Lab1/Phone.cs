using System;

namespace VP_lab1
{
    enum Processor
    {
        Aboba,
        Kwantory,
        Exenos,
        Tor,
        Lighting,
        MixFight,
        Delta
    }
    enum Company
    {
        TheRock,
        Cubix,
        ElectroHeart,
        Dodli,
        Roots,
        Xiaomi,
        Apple,
        Samsung
    }
    internal class Phone
    {

        private string name;
        private double display;
        private Processor processor;
        private byte memory;
        private int price;
        private bool inStock;
        private Company company;
        private DateTime date;


        public string Name
        {
            get { return name; }
            set { if (value != "") name = value; }
        }
        public double Display
        {
            get { return display; }
            set { if (value != 0) display = value; }
        }
        public Processor Processor
        {
            get { return processor; }
            set { processor = value; }
        }
        public byte Memory
        {
            get { return memory; }
            set { if (value != 0) memory = value; }
        }
        public int Price
        {
            get { return price; }
            set { if (value != 0) price = value; }
        }
        public bool InStock
        {
            get { return inStock; }
            set { inStock = value; }
        }
        public Company Company
        {
            get { return company; }
            set { company = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}