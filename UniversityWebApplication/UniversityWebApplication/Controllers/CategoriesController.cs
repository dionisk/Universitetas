using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityWebApplication.Models;

namespace UniversityWebApplication.Controllers
{
    public class CategoriesController : Controller
    {

        private static List<Category> categories = new List<Category>
        {
            new Category {Id = 1, Name = "General"}
        };
        // GET: CategoriesController
        public ActionResult Index()
        {
            return View(categories);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            return View(categories.Find(existingCategory => existingCategory.Id == id));
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category newCategory)
        {
            try
            {
                categories.Add(newCategory);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(newCategory);
            }
        }

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(categories.Find(existingCategory => existingCategory.Id == id));
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category editedCategory)
        {
            try
            {
                categories.RemoveAll(existingCategory => existingCategory.Id == id);
                categories.Add(editedCategory);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(editedCategory);
            }
        }

        // GET: CategoriesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(categories.Find(existingCategory => existingCategory.Id == id));
        }

        // POST: CategoriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                categories.RemoveAll(existingCategory => existingCategory.Id == id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
