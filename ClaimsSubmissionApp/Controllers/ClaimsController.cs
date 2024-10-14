using Microsoft.AspNetCore.Mvc;
using ClaimsSubmissionApp.Data;
using ClaimsSubmissionApp.Models;
using System.Linq;

namespace ClaimsSubmissionApp.Controllers
{
    public class ClaimsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClaimsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Claims/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Claims/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Claim claim)
        {
            if (ModelState.IsValid)
            {
                _context.Claims.Add(claim);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(claim);
        }

        // GET: Claims
        public IActionResult Index()
        {
            var claims = _context.Claims.ToList();
            return View(claims);
        }
    }
}