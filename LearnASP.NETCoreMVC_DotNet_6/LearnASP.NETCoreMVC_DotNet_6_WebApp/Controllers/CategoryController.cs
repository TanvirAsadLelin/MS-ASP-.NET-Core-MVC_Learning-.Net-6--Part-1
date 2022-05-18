using LearnASP.NETCoreMVC_DotNet_6_WebApp.Data;
using LearnASP.NETCoreMVC_DotNet_6_WebApp.Models;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace LearnASP.NETCoreMVC_DotNet_6_WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _Db;

        public CategoryController(ApplicationDbContext Db)
        {
            _Db = Db;   
        }
        public IActionResult Index()
        {   
            //var objCategoryList = _Db.Categories.ToList();  
            IEnumerable<Category> objCategoryList = _Db.Categories;
             return View(objCategoryList);
        }

        //Get method

        public IActionResult Create()
        {
         
            return View();
        }

        //Post
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Category obj)
        {   
            if (ModelState.IsValid)
            {
                _Db.Categories.Add(obj);
                _Db.SaveChanges();

                return RedirectToAction("Index");
            }
         return View(obj);
        }
    }
}
