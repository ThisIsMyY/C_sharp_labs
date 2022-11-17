using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_lab1_OOP
{
    internal class Company
    {
        protected string companyName;
        protected string companyAddress;
        public string CompanyName {
            get { return companyName; }
            set { if (value != "") companyName = value; } 
        }
        public string CompanyAddress {
            get { return companyAddress; }
            set { if (value != "") companyAddress = value; } 
        }
    }
}
