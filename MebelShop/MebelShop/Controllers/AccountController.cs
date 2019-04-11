using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MebelShop.data;
using MebelShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Web;
using MebelShop.Extensions;
using static MebelShop.Utilities.Utilities;
using Microsoft.AspNetCore.Hosting;

namespace MebelShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly MebelContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IHostingEnvironment _env;
        public AccountController(UserManager<ApplicationUser> userManager,
                                RoleManager<IdentityRole> roleManager,
                                 MebelContext  context,
                                 SignInManager<ApplicationUser> signInManager,
                                 IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _env = env;
        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        // GET: Account/Details/5
        public ActionResult Register(int id)
        {
            return View();
        }
        [HttpPost,ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(Register register)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Model is not valit");
                return View(register);
            }
            var user = new ApplicationUser()
            {
                Email = register.Email,
                UserName = register.Email,
                Lastname = register.Lastname,
                FirstName = register.Firstname,


            };
            var result = await _userManager.CreateAsync(user, register.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }
            await _userManager.AddToRoleAsync(user,SD.UserRole);
            await _signInManager.SignInAsync(user, false);
            return RedirectToAction("Index", "Home");
        }

        // GET: Account/Create
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]

        public async Task<ActionResult> Login( LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Model is not valid");
                return View(loginModel);
            }

            var user = await _userManager.FindByEmailAsync(loginModel.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Email or password");
                return View(loginModel);
            }
            var result = await _signInManager.PasswordSignInAsync(user,loginModel.Password, loginModel.RemenberMe,true);
            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "Not dear user, you were locked out for 5 minutes. Please, be patient!");

                return View(loginModel);
            }
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", " Email or password wrong");
                return View(loginModel);
            }
            return RedirectToAction("Index", "Home");
        
        }
       

        
        public async Task<ActionResult> Logout(LoginModel loginModel)
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<ActionResult> Profile(string Id)
        {
          var user=  await _userManager.FindByNameAsync(Id);
         var result= await  _userManager.FindByIdAsync(user.Id);
            
            return View(result);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<ActionResult> Profile(ApplicationUser  User)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("","Model is not valid");
                return View(User);
            }
            var userDb = await _userManager.FindByEmailAsync(User.Email);
            if( User.Photo != null) {
                if (!User.Photo.IsImages())
                {
                    ModelState.AddModelError("Photo", "Photo is not valid.");
                    User.Image = userDb.Image;
                    return View(User);
                }
                if(userDb.Image != null)
                {
                    RemoveFile(_env.WebRootPath, userDb.Image);

                }

                userDb.Image =  await User.Photo.SaveImagesAsync(_env.WebRootPath, "Profile");
            }
            userDb.Email = User.Email;
            userDb.Lastname = User.Lastname;
            userDb.FirstName = User.FirstName;
         await   _userManager.UpdateAsync(userDb);

            return RedirectToAction("Index", "Home");
        }
    }
}