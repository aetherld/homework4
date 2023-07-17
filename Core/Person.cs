using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Core.Models
{
    internal class Person
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateBirth { get; set; }
        public char EmailAddress  { get; set; }

        public List<Info> Infos { get; set; }
        public List<Address> Adresses { get; set; }

    }
}
