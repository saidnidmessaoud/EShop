using EShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Computer> ComputerIsRecommend { get; set; }
    }
}
