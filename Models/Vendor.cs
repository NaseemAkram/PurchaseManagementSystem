using System.ComponentModel.DataAnnotations;

namespace PurchaseManagementSystem.Models
{
    public class Vendor
    {
        [Key]
        public int Vendor_Id { get; set; }
        public string Vendor_Name { get; set; }
    }
}
