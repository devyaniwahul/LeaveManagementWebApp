using LeaveManagementWebApp.Data;

namespace LeaveManagementWebApp.Models
{
    public class EmployeeAllocationVM : EmployeeListVM
    {
        public List<LeaveAllocationVM> leaveAllocations { get; set; }
    }
}
