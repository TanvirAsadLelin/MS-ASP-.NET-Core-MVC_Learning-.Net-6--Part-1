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
            if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("CustomError", "The Display order is not exactly same as name!");
            }
            if (ModelState.IsValid)
            {
                _Db.Categories.Add(obj);
                _Db.SaveChanges();

                return RedirectToAction("Index");
            }
         return View(obj);
        }


        //Get method

        public IActionResult Edit(int? id )
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _Db.Categories.Find(id);
            //var categoryFromDbFirst = _Db.Categories.FirstOrDefault(u=>u.Id == id);
           // var categoryFromDbSingle = _Db.Categories.SingleOrDefault(u=>u.Id == id);

            if(categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        //Post
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("CustomError", "The Display order is not exactly same as name!");
            }
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
