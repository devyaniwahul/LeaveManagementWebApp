using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWebApp.Models
{
    public class EmployeeListVM
    {
        public string Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Display(Name = "Joining Date")]
        public DateTime DateJoined { get; set; }
        [Display(Name = "Email Id")]
        public string Email { get; set; }
    }
}
