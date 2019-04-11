using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MebelShop.Models;
using MebelShop.data;
using MebelShop.Models.ProductVM;
using Microsoft.AspNetCore.Identity;

namespace MebelShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly MebelContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public HomeController(MebelContext context,UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }
        public IActionResult Index()
        {
            var vm = new ProductVM()
            {
                Product = _context.Products,
                Images=_context.Images,
                Category=_context.Categories,
                Favorites=_context.Favorites
            };
           ViewBag.userId =_userManager.GetUserId(HttpContext.User);
            return View(vm);
        }
        public async Task<ActionResult> AddFovarite(int? id,string email)
        {
         var user= await  _userManager.FindByEmailAsync(email);
           var product= _context.Products.Find(id);
            var favorite = new Favorite()
            {
                ProductId = product.Id,
                UserId=user.Id

            };
            _context.Favorites.Add(favorite);
          await  _context.SaveChangesAsync();
            return Json(new { success = true, responseText = "Your message successfuly sent!" });
        }
        public async Task<IActionResult> RemoveFovarite(int? id,string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var favorite = _context.Favorites.Where(p => p.ProductId == id).Where(p=>p.UserId==user.Id);
             
            _context.Favorites.RemoveRange(favorite);
            await _context.SaveChangesAsync();
            return Json(new { success = true, responseText = "Your message successfuly sent!" });

        
        }
        public async Task<ActionResult> Details(int? Id)
        {
            var product = await _context.Products.FindAsync(Id);
            //if (product==null)
            //{
            //    return RedirectToAction("Index", "Home");
            //}
            var vm = new DetailVM()
            {
                Product=product,
                Images=_context.Images,
                Category=_context.Categories
            };
            return View(vm);
        }
    }
}
