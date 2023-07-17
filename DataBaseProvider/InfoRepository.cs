using ConsoleApp7.Core.Models;
using ConsoleApp7.DataBaseProvider.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.DataBaseProvider.Repositories.Implementations
{
    public class InfoRepository : Repository<Info>, IInfoRepository
    {
        public InfoRepository(ApplicationContext context)
            : base(context)
        {
        }

        public List<Info> GetAll()
        {
            return Entities.ToList();
        }

        public Info GetById(int id)
        {
            return Entities.Where(a => a.Id == id).FirstOrDefault();
        }
    }
