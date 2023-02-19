using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Models
{
    public interface IComputerRepository
    {
        IEnumerable<Computer> GetAllComputer { get; }
        IEnumerable<Computer> GetComputerIsRecommend { get; }
        Computer GetComputerById(int computerId);
    }
}
