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
    {
        private readonly AppDbContext _db;
        
        public WorkersController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Worker> objtList = _db.Workers;
            return View(objtList);
        }
        //create the thing
        public IActionResult Create()
        {   
            return View();
        }
        //post the thing
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
        //just editing the thing
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
    }
}
