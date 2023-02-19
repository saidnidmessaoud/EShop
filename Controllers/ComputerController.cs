using EShop.Models;
using EShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Controllers
{
    public class ComputerController : Controller
    {

        private readonly IComputerRepository _computerRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ComputerController(IComputerRepository computerRepository, ICategoryRepository categoryRepository)
        {
            _computerRepository = computerRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Computer> computers;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                computers = _computerRepository.GetAllComputer.OrderBy(c => c.ComputerId);
                currentCategory = "All Laptops";
            }
            else
            {
                computers = _computerRepository.GetAllComputer.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            var computerListViewModel = new ComputerListViewModel
            {
                Computers = computers,
                CurrentCategory = currentCategory
            };

            return View(computerListViewModel);
            
        }

        public IActionResult Details(int id)
        {
            var computer = _computerRepository.GetComputerById(id);
            if(computer == null)
            {
                return NotFound();
            }

            return View(computer);
        }
    }
}
