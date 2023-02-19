using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.ViewModels
{
    public class ComputerListViewModel
    {

        public IEnumerable<Computer> Computers { get; set; }
        public string CurrentCategory { get; set; }

    }
}
