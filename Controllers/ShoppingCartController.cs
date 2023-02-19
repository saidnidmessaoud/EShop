using EShop.Models;
using EShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IComputerRepository _computerRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IComputerRepository computerRepository, ShoppingCart shoppingCart)
        {
            _computerRepository = computerRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int computerId)
        {
            var selectedComputer = _computerRepository.GetAllComputer.FirstOrDefault(c => c.ComputerId == computerId);

            if (selectedComputer != null)
            {
                _shoppingCart.AddToCart(selectedComputer, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int computerId)
        {
            var selectedComputer = _computerRepository.GetAllComputer.FirstOrDefault(c => c.ComputerId == computerId);

            if (selectedComputer != null)
            {
                _shoppingCart.RemoveFromCart(selectedComputer);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}
