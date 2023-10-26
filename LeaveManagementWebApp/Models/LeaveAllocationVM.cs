using LeaveManagementWebApp.Data;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWebApp.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }
        [Display(Name = "Number of Days")]
        [Required]
        [Range(1, 50, ErrorMessage ="Invalid Number Entered")]
        public int NumberOfDays { get; set; }
        [Display(Name = "Allocation Period")]

        public int period { get; set; }
        public LeaveTypesVM? LeaveType { get; set; }
    }
}