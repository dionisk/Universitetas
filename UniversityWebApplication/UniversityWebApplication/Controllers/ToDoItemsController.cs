using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityWebApplication.Models;

namespace UniversityWebApplication.Controllers
{
    public class ToDoItemsController : Controller
    {

        private static List<ToDoItem> toDoItems = new List<ToDoItem>
        {
            new ToDoItem {Id = 1, Name = "To create ToDoItem list", Description = "To create list to initialize the list", Priority = 1}
        };

        // GET: ToDoItemsController
        public ActionResult Index()
        {
            return View(toDoItems);
        }

        // GET: ToDoItemsController/Details/5
        public ActionResult Details(int id)
        {
            return View(toDoItems.Find(existingToDoItem => existingToDoItem.Id == id));
        }

        // GET: ToDoItemsController/Create
        public ActionResult Create()
        {
            return View();
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
                    toDoItems.Add(newToDoItem);
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
        public ActionResult Edit(int id)
        {
            return View(toDoItems.Find(existingToDoItem => existingToDoItem.Id == id));
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
                    toDoItems.RemoveAll(existingToDoItem => existingToDoItem.Id == id);
                    toDoItems.Add(editedToDoItem);
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
        public ActionResult Delete(int id)
        {
            return View(toDoItems.Find(existingToDoItem => existingToDoItem.Id == id));
        }

        // POST: ToDoItemsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ToDoItem deletedToDoItem)
        {
            try
            {
                toDoItems.RemoveAll(existingToDoItem => existingToDoItem.Id == id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(deletedToDoItem);
            }
        }
    }
}
