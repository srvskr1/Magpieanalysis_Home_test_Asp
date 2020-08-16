using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoSql.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoSql.Controllers
{
    public class DemoController : Controller
    {
        private readonly DemoDBContex _db;
        public DemoController(DemoDBContex db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displaydata = _db.stockmarket.ToList();
            return View(displaydata);
        }

        public async Task<IActionResult> Edit(int? id) 
        {
            if(id==null)
            {
                return RedirectToAction("Index");
            }
            var getdetails = await _db.stockmarket.FindAsync(id);
            return View(getdetails);
            
        }
        [HttpPost]
        public async Task<IActionResult> Edit(demoDB db)
        {
            if(ModelState.IsValid)
            {
                _db.Update(db);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return ((IActionResult)db);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getdetails = await _db.stockmarket.FindAsync(id);
            return View(getdetails);

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getdetails = await _db.stockmarket.FindAsync(id);
            return View(getdetails);

        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            
            var getdetails = await _db.stockmarket.FindAsync(id);
            _db.stockmarket.Remove(getdetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
