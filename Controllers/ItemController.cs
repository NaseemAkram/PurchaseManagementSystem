using Microsoft.AspNetCore.Mvc;
using PurchaseManagementSystem.DataContext;
using PurchaseManagementSystem.Models;

namespace PurchaseManagementSystem.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Display()
        {
            IList<Item> items = _context.Items.OrderByDescending(o => o.Item_Id).ToList();

            return View(items);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Item items)
        {
            if (items != null)
            {
                _context.Items.Add(items);
                _context.SaveChanges();

                return RedirectToAction("Display");

            }
            return View(items);
        }

        public IActionResult Edit(int id)
        {
            var item = _context.Items.Where(i => i.Item_Id == id).FirstOrDefault();
            return View(item);

        }

        [HttpPost]
        public IActionResult Edit(Item items)
        {
            var item = _context.Items.Where(i => i.Item_Id == items.Item_Id).FirstOrDefault();
            item.Item_Name = items.Item_Name;
            item.Item_Status = items.Item_Status;
            _context.SaveChanges();
            return RedirectToAction("Display");
        }



        public IActionResult Delete(int id)
        {
            var item = _context.Items.Where(i => i.Item_Id == id).FirstOrDefault();
            return View(item);

        }
        [HttpPost]
        public IActionResult Delete(Item items)
        {
            var item = _context.Items.Where(i => i.Item_Id == items.Item_Id).FirstOrDefault();
            _context.Items.Remove(item);
            _context.SaveChanges();
            return RedirectToAction("Display");

        }


        public IActionResult Details(int id)
        {
            var details = _context.Items.Where(i => i.Item_Id == id).FirstOrDefault();
            return View(details);
        }
    }
}
