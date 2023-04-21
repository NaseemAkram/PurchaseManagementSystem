using System.ComponentModel.DataAnnotations;

namespace PurchaseManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int Emp_Id { get; set; }

        public string Emp_Name { get; set; }
    }
}
