using System.ComponentModel.DataAnnotations;

namespace PurchaseManagementSystem.Models
{
    public class Item
    {
        [Key]

        public int Item_Id { get; set; }

        public string Item_Name { get; set; }
        public string Item_Status { get; set; }
    }
}
