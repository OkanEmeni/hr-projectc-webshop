﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using klaas.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace klaas.Controllers
{
    public class HomeController : Controller
    {
        protected UserManager<Users> mUserManager;
        protected SignInManager<Users> mSignInManager;
        private readonly WebshopContext _context;
       

         public HomeController(
            
            UserManager<Users> userManager,
            SignInManager<Users> signInManager, WebshopContext context)
            {
            
            mUserManager = userManager;
            mSignInManager = signInManager;
             _context = context;
        }
        public IActionResult Index()
        {
            var myList = new List<string>();
            var productsoorten = from m in _context.Productsoort select new {m.Naam};
            
            
            foreach (var product in productsoorten){
                myList.Add(product.ToString());
                Console.WriteLine(product.Naam);
            }
            var myArray = myList.ToArray();
            ViewData["productsoorten"] =  myArray;
            var result =  from m in _context.Productwaarde select m;
            return View("Mainpage",result);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

         public IActionResult Mainpage()
        {
            var myList = new List<string>();
            var productsoorten = from m in _context.Productsoort select new {m.Naam};
            
            
            foreach (var product in productsoorten){
                myList.Add(product.ToString());
                Console.WriteLine(product.Naam);
            }
            var myArray = myList.ToArray();
            ViewData["productsoorten"] =  myArray;
            var result =  from m in _context.Productwaarde select m;
            return View(result);
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Mainpage(string hi)
        {
            var myList = new List<string>();
            var productsoorten = from m in _context.Productsoort select new {m.Naam};
            foreach (var product in productsoorten){
                myList.Add(product.ToString());
                Console.WriteLine(product.Naam);
            }
            var myArray = myList.ToArray();
            ViewData["productsoorten"] =  myArray;
             if (hi == null)
            {
                var productwaardenq =  from m in _context.Productwaarde select m;
                return View(productwaardenq);
            }
            else if (hi == "select all"){
                var productwaardenq =  from m in _context.Productwaarde select m;
                return View(productwaardenq);
            }
            else{
            var productsoortid = 0;
            var productsoortidq = from m in _context.Productsoort where m.Naam == hi select m;
            foreach (var product in productsoortidq){
               productsoortid = product.Id;
            }
            var productwaardenq =  from m in _context.Productwaarde where productsoortid == m.ProductsoortId select m;
            return View(productwaardenq);
            }
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Signin()
        {
            ViewData["Message"] = "LogIn.";

            return RedirectToAction("Login", "Account");
        }
        public IActionResult signup()
        {
            ViewData["Message"] = "Sign Up.";

            return RedirectToAction("Register", "Account");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // [Route ("signup")]
        // public async Task<IActionResult> CreatUserAsync(){
        //     var result = await mUserManager.CreateAsync(new Users{
        //         UserName = "halim",
        //         Email = "halim@gmail.com"
        //     }, "1.Password");
        //     if (result.Succeeded)
        //         return Content("user was created", "text/html");
            
        //     return Content ("user creation faild", "text/html");
        // }

        [Authorize]
        [Route("profile")]
        public IActionResult userProfile(){
            return Content($"Welcome {HttpContext.User.Identity.Name} this is your profile.", "text/html");
        }

        // [Route("login")]
        // public async Task <IActionResult> login(string returnUrl){
        //    await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);
        //    var result = await mSignInManager.PasswordSignInAsync("halim", "1.Password", true, false);
        //    if (result.Succeeded){
        //        if (string.IsNullOrEmpty(returnUrl))
        //             return RedirectToAction(nameof(Index));
        //     return Redirect (returnUrl);
        //    }
        //    return Content("Faild to login", "text/html");
        // }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Registersign(register vm){
            if (ModelState.IsValid){
            
            var user = new Users {UserName = vm.email, Email = vm.email};
            var result = await mUserManager.CreateAsync(user, vm.password);
            if (result.Succeeded){
                await mSignInManager.SignInAsync(user, false);
                return RedirectToAction("Index", "Home");
            }else{
                    foreach (var error in result.Errors){
                    ModelState.AddModelError("", error.Description);
                    }               
                }
            }
            return Content("vm");  
        }
        
        [HttpGet]
        [Route("logout")]
        public async Task <IActionResult> logout(){
            await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);
            return Content ("Logged out.", "text/html");
        }
    }
}
