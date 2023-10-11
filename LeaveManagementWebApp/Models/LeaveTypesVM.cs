using LeaveManagementWebApp.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementWebApp.Models
{
    public class LeaveTypesVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default Number Of Days")]
        [Required]
        [Range(1, 25, ErrorMessage ="Please enter a valid number")]
        public int DefaultDays { get; set; }
    }
}
