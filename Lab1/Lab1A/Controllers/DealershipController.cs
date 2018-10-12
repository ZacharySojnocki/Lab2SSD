using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab1A.Models;
using Lab1A.Data;
// I, Zachary Sojnocki, 000367577, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.
namespace Lab1A.Controllers
{
    public class DealershipController : Controller
    {

        public DealershipController()
        {
        }

        // GET: Dealership
        public async Task<IActionResult> Index()
        {
            return View(DealershipMgr.GetDealershipList());
        }

        // GET: Dealership/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dealership = DealershipMgr.GetDealership(id);
            if (dealership == null)
            {
                return NotFound();
            }

            return View(dealership);
        }

        // GET: Dealership/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dealership/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Email,PhoneNumber")] Dealership dealership)
        {
            if (ModelState.IsValid)
            {
                DealershipMgr.AddDealership(dealership);
                return RedirectToAction(nameof(Index));
            }
            return View(dealership);
        }

        // GET: Dealership/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dealership = DealershipMgr.GetDealership(id);
            if (dealership == null)
            {
                return NotFound();
            }
            return View(dealership);
        }

        // POST: Dealership/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Email,PhoneNumber")] Dealership dealership)
        {
            if (id != dealership.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                DealershipMgr.UpdateDealership(id, dealership);
                return RedirectToAction(nameof(Index));
            }
            return View(dealership);
        }

        // GET: Dealership/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var dealership = DealershipMgr.GetDealership(id);
            if (dealership == null)
            {
                return NotFound();
            }

            return View(dealership);
        }

        // POST: Dealership/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            DealershipMgr.DeleteDealership(id);
            return RedirectToAction(nameof(Index));
        }

        private bool DealershipExists(int id)
        {
            return DealershipMgr.GetDealershipList().Any(e => e.ID == id);
        }
    }
}
