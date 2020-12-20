using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityWebApplication.Data;
using UniversityWebApplication.Models;

namespace UniversityWebApplication.Controllers
{
    public class ToDoItemsController : Controller
    {
        private readonly UniversityContext context;

        public ToDoItemsController(UniversityContext context)
        {
            this.context = context;
        }

        // GET: ToDoItemsController
        public ActionResult Index()
        {
            return View(context.ToDoItems);
        }

        // GET: ToDoItemsController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await context.ToDoItems.FindAsync(id));
        }

        // GET: ToDoItemsController/Create
        public ActionResult Create()
        {
            ToDoItem toDoItem = new ToDoItem
            {
                CreationDate = DateTime.Now,
                Status = ToDoItemStatus.Backlog,
                Priority = 3
            };
            return View(toDoItem);
        }

        // POST: ToDoItemsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ToDoItem newToDoItem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.ToDoItems.Add(newToDoItem);
                    context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                } 
                return View(newToDoItem);
            }
            catch
            {
                return View(newToDoItem);
            }
        }

        // GET: ToDoItemsController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View(await context.ToDoItems.FindAsync(id));
        }

        // POST: ToDoItemsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ToDoItem editedToDoItem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.ToDoItems.Update(editedToDoItem);
                    context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View(editedToDoItem);
            }
            catch
            {
                return View(editedToDoItem);
            }
        }

        // GET: ToDoItemsController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await context.ToDoItems.FindAsync(id));
        }

        // POST: ToDoItemsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ToDoItem deletedToDoItem)
        {
            try
            {
                context.ToDoItems.Remove(deletedToDoItem);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(deletedToDoItem);
            }
        }
    }
}
