using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MebelShop.data;
using MebelShop.Models;
using MebelShop.Models.ProductVM;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MebelShop.Extensions;
using static MebelShop.Utilities.Utilities;
using Microsoft.AspNetCore.Authorization;

namespace MebelShop.Areas.Admin.Controllers
{


    [Area("Admin")]
    [Authorize(Roles = SD.AdminRole)]
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly MebelContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IHostingEnvironment _env;
        public AdminController(UserManager<ApplicationUser> userManager,
                                RoleManager<IdentityRole> roleManager,
                                 MebelContext context,
                                 SignInManager<ApplicationUser> signInManager,
                                 IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _env = env;
        }
        // GET: Admin
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Index(LoginModel loginModel)

        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Email or password wrong");
                return View(loginModel);
            }
            var user = await _userManager.FindByEmailAsync(loginModel.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Email or password wrong");
                return View(loginModel);
            }
            var result = await _signInManager.PasswordSignInAsync(user, loginModel.Password, loginModel.RemenberMe, true);

            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "Not dear user, you were locked out for 5 minutes. Please, be patient!");
                return View(loginModel);
            }

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email or password is wrong");
                return View(loginModel);
            }
            return RedirectToAction("Details", "Admin");
        }

        // GET: Admin/Details/5
        public ActionResult Details()
        {
            var vm = new ProductVM()
            {
                Product = _context.Products.ToList(),
                Category = _context.Categories.ToList(),
                Images = _context.Images.ToList(),



            };
            return View(vm);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            ViewBag.Category = _context.Categories;
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        
        public async Task<ActionResult> Create([Bind(include:"Id,Name,Description,Price,CategoryId,News")]Product product, IFormFile[] Photo)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Model is not valid");
                ViewBag.Category = _context.Categories;

                return View(product);
            }
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            if (Photo.Length == 0)
            {
                ModelState.AddModelError("", "Model is not valid");
                ViewBag.Category = _context.Categories;

                return View(product);
            }
            foreach (var picture in Photo)
            {
                if (!picture.IsImages())
                {
                    ModelState.AddModelError("", "Model is not valid");
                    ViewBag.Category = _context.Categories;

                    return View(product);
                }
                var photo = new Images()
                {
                    ProductId = product.Id,
                    Name = await picture.SaveImagesAsync(_env.WebRootPath, "Product")
                   
                };
                _context.Images.Add(photo);
            }
             
           await  _context.SaveChangesAsync();

            return  RedirectToAction("Details", "Admin");


        }
        
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Details", "Admin");
            }

            var product=  await  _context.Products.FindAsync(id);
            if (product == null)
            {
                return RedirectToAction("Details", "Admin");
            }
            var images =  _context.Images.Where(p => p.ProductId == id);
            if (images != null)
            {
                _context.Images.RemoveRange(images);
                await _context.SaveChangesAsync();
            }

            
            _context.Products.Remove(product);
           await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Admin");
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Details", "Admin");
            }
          var product=  _context.Products.Find(id);
            if (product == null)
            {
                return RedirectToAction("Details", "Admin");
            }
            ViewBag.image = _context.Images.Where(p => p.ProductId == id);
            ViewBag.Category = _context.Categories; 
            return View(product);
        }


        [HttpPost]
        public async Task<ActionResult> Edit([Bind(include: "Id,Name,Description,Price,CategoryId,News")]Product product, IFormFile[] Photo)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Model is not valid");
                ViewBag.image = _context.Images.Where(p => p.ProductId ==product.Id);
                ViewBag.Category = _context.Categories;
                return View(product);
            }
            var productDb = _context.Products.Find(product.Id);
            productDb.Name = product.Name;
            productDb.Description = product.Description;
            productDb.CategoryId = product.CategoryId;
            productDb.News = product.News;
            productDb.Price = product.Price;          
            await _context.SaveChangesAsync();
            if (Photo.Length == 0)
            {
                return RedirectToAction("Details", "Admin");

            }
            var img = _context.Images.Where(p => p.ProductId == product.Id);
            foreach (var item in img)
            {
                RemoveFile(_env.WebRootPath, item.Name);
                
            }
            foreach (var picture in Photo)
            {
                if (!picture.IsImages())
                {
                    ModelState.AddModelError("", "Model is not valid");
                    ViewBag.Category = _context.Categories;

                    return View(product);
                }
                var photo = new Images()
                {
                    ProductId = product.Id,
                    Name = await picture.SaveImagesAsync(_env.WebRootPath, "Product")

                };
               
                _context.Images.Add(photo);
            }
            _context.Images.RemoveRange(img);
           
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Admin");
        }

    }
}