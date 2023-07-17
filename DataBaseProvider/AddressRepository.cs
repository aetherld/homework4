using ConsoleApp7.Core.Models;
using ConsoleApp7.DataBaseProvider.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.DataBaseProvider.Repositories.Implementations
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(ApplicationContext context)
            : base(context)
        {
        }

        public List<Address> GetAll()
        {
            return Entities.ToList();
        }

        public Address GetById(int id)
        {
            return Entities.Where(a => a.Id == id).FirstOrDefault();
        }
    }
}
