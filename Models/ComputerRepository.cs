using EShop.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Models
{
    public class ComputerRepository : IComputerRepository
    {

        private readonly ApplicationDbContext _applicationDbContext;

        public ComputerRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Computer> GetAllComputer
        {
            get
            {
                return _applicationDbContext.Computers.Include(c => c.Category);
            }
        }

        public IEnumerable<Computer> GetComputerIsRecommend
        {
            get
            {
                return _applicationDbContext.Computers.Include(c => c.Category).Where(p => p.IsOnRecommend);
            }
        }

        public Computer GetComputerById(int computerId)
        {
            return _applicationDbContext.Computers.FirstOrDefault(c => c.ComputerId == computerId);
        }
    }
}
