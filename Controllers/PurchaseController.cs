using Microsoft.AspNetCore.Mvc;
using PurchaseManagementSystem.DataContext;
using PurchaseManagementSystem.Models;

namespace PurchaseManagementSystem.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PurchaseController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Display()
        {
            IList<Item> items = _context.Items.OrderByDescending(i => i.Item_Id).ToList();

            return View(items);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Purchase purchase)
        {
            if (purchase != null)
            {
                _context.Purchases.Add(purchase);
                _context.SaveChanges();
                return RedirectToAction("Display");
            }
            return View(purchase);
        }

        public IActionResult Edit(int id)
        {
            var purchase = _context.Purchases.Where(i => i.Purchase_Id == id).FirstOrDefault();

            return View(purchase);
        }
        [HttpPost]
        public IActionResult Edit(Purchase purchase)
        {
            var pro = _context.Purchases.Where(i => i.Purchase_Id == purchase.Purchase_Id).FirstOrDefault();

            pro.Purchase_Item = purchase.Purchase_Item;
            pro.Vendor = purchase.Vendor;
            pro.Purchase_Quantity = purchase.Purchase_Quantity;
            pro.Price = purchase.Price;
            pro.Purchase_Date = purchase.Purchase_Date;
            _context.SaveChanges();
            return RedirectToAction("Display");
        }
    }
}
