using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Core.Models
{
    internal class Info
    {
        public int StudentNumber { get; set; }
        public double AverageMark { get; set; }


        public List<Person> Persons { get; set; }
        public List<Address> Adresses { get; set; }
    }
}
