using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChekingSys.Data;
using ChekingSys.Models;

namespace ChekingSys.Controllers
{
    public class WorkersController : Controller
    {//This is the Worker page code.
        private readonly AppDbContext _db;
        //Connection with the database.
        public WorkersController(AppDbContext db)
        {
            _db = db;
        }
        //Loading the worker list from the database.
        public IActionResult Index()
        {
            IEnumerable<Worker> objtList = _db.Workers;
            return View(objtList);
        }
        //Here you can create a new worker entry into the list.
        public IActionResult Create()
        {   
            return View();
        }
        //And here it gets saved inside the database.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Worker obj)
        {
            if(ModelState.IsValid)
            {
                _db.Workers.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //Edit for the worker table.
        public IActionResult Edit(int? id)
        {
            if(id==null || id==0)
            {
                return NotFound();
            }
            var obj = _db.Workers.Find(id);
            if(obj==null)
            {
                return NotFound();
            }

            return View();
        }
        //The edit gets saved.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Worker obj)
        {
            if (ModelState.IsValid)
            {
                _db.Workers.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //Worker entry deletion.
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Workers.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View();
        }
        //Confirming the deletion and saving the changes.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(int? id)
        {
            var obj = _db.Workers.Find(id);
            if (obj==null)
            {
                return NotFound();
            }
            
                _db.Workers.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            
            return View(obj);
        }
    }
}
