using System.ComponentModel.DataAnnotations;

namespace PurchaseManagementSystem.Models
{
    public class Purchase
    {

        [Key]
        public int Purchase_Id { get; set; }
        public string Purchase_Item { get; set; }
        public int Purchase_Quantity { get; set; }

        public DateTime Purchase_Date { get; set; }
        public int Price { get; set; }

        public string Vendor { get; set; }
    }
}
