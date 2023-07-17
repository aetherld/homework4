using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.DataBaseProvider.Repositories.Abstractions
{
    public interface IAddressRepository : IRepository<Address>
    {
        public List<Address> GetAll();
        public Address GetById(int id);
    }
}
}
