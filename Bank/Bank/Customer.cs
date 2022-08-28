using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Customer
    {
        private string name { get; set; }

        private int age { get; set; }

        private List<BankAccount> accounts { get; set; }

        public Customer(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;
        }
    }
}
