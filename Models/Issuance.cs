using System.ComponentModel.DataAnnotations;

namespace PurchaseManagementSystem.Models
{
    public class Issuance
    {
        [Key]
        public int Issue_Id { get; set; }
        public DateTime Issue_Date { get; set; }

        public string Employee_Name { get; set; }

        public int Quantity { get; set; }
    }
}
