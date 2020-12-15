using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityWebApplication.Data;
using UniversityWebApplication.Models;
using UniversityWebApplication.Providers;

namespace UniversityWebApplication.Controllers
{
    public class CategoriesController : Controller
    {

        private readonly UniversityContext context;

        public CategoriesController(UniversityContext context)
        {
            this.context = context;
        }
        // GET: CategoriesController
        public ActionResult Index()
        {
            return View(context.Categories);
        }

        // GET: CategoriesController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await context.Categories.FindAsync(id));
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
                if (ModelState.IsValid)
                {
                    context.Categories.Add(newCategory);
                    context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View(newCategory);
            }
            catch
            {
                return View(newCategory);
            }
        }

        // GET: CategoriesController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View(await context.Categories.FindAsync(id));
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category editedCategory)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.Update(editedCategory);
                    context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View(editedCategory);
            }
            catch
            {
                return View(editedCategory);
            }
        }

        // GET: CategoriesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.Categories.Find(id));
        }

        // POST: CategoriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category deletedCategory)
        {
            try
            {
                context.Categories.Remove(deletedCategory);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
