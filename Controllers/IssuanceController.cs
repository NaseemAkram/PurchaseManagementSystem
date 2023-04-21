using Microsoft.AspNetCore.Mvc;
using PurchaseManagementSystem.DataContext;
using PurchaseManagementSystem.Models;

namespace PurchaseManagementSystem.Controllers
{
    public class IssuanceController : Controller
    {


        private readonly ApplicationDbContext _context;

        public IssuanceController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Display()
        {
            IList<Issuance> issues = _context.Issuance.OrderByDescending(i => i.Issue_Id).ToList();


            return View(issues);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Issuance issuess)
        {
            if (issuess != null)
            {
                _context.Issuance.Add(issuess);
                _context.SaveChanges();
                return RedirectToAction("Display");
            }
            return View(issuess);
        }



        public IActionResult Edit(int id)
        {
            var issue = _context.Issuance.Where(i => i.Issue_Id == id).FirstOrDefault();

            return View(issue);
        }
        [HttpPost]
        public IActionResult Edit(Issuance issues)
        {
            var isu = _context.Issuance.Where(i => i.Issue_Id == issues.Issue_Id).FirstOrDefault();

            isu.Issue_Date = issues.Issue_Date;
            isu.Employee_Name = issues.Employee_Name;
            isu.Quantity = issues.Quantity;

            _context.SaveChanges();
            return RedirectToAction("Display");
        }




        public IActionResult Delete(int id)
        {
            var item = _context.Issuance.Where(i => i.Issue_Id == id).FirstOrDefault();
            return View(item);

        }
        [HttpPost]
        public IActionResult Delete(Issuance isues)
        {
            var item = _context.Issuance.Where(i => i.Issue_Id == isues.Issue_Id).FirstOrDefault();
            _context.Issuance.Remove(item);
            _context.SaveChanges();
            return RedirectToAction("Display");

        }


        public IActionResult Details(int id)
        {
            var details = _context.Issuance.Where(i => i.Issue_Id == id).FirstOrDefault();
            return View(details);
        }
    }
}
