using System;

namespace VP_lab1
{
    /*public enum Processor
    {
        Aboba,
        Kwantory,
        Exenos,
        Tor,
        Lighting,
        MixFight,
        Delta
    }
    public enum Company
    {
        TheRock,
        Cubix,
        ElectroHeart,
        Dodli,
        Roots,
        Xiaomi,
        Apple,
        Samsung
    }*/
    public class Phone
    {
        private string name;
        private double? display;
        private string processor;
        private byte? memory;
        private int? price;
        private bool? inStock;
        private string company;
        private bool? limitedEdition;
        private DateTime date;


        public string Name
        {
            get { return name; }
            set { if (value != "") name = value; }
        }
        public double? Display
        {
            get { return display; }
            set { if (value != 0) display = value; }
        }
        public string Processor
        {
            get { return processor; }
            set { processor = value; }
        }
        public byte? Memory
        {
            get { return memory; }
            set { if (value != 0) memory = value; }
        }
        public int? Price
        {
            get { return price; }
            set { if (value != 0) price = value; }
        }
        public bool? InStock
        {
            get { return inStock; }
            set { inStock = value; }
        }
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        public bool? LimitedEdition
        {
            get { return limitedEdition; }
            set { limitedEdition = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public Phone()
        {
            Name = "Unknown";
            Display = null;
            Processor = "Unknown";
            Memory = null;
            Price = null;
            InStock = null;
            Company = "Unknown";
            LimitedEdition = null;
            Date = DateTime.Now;
        }
    }
}