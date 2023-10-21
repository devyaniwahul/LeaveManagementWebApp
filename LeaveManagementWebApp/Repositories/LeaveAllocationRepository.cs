using LeaveManagementWebApp.Contracts;
using LeaveManagementWebApp.Data;
using Microsoft.AspNetCore.Identity;
using LeaveManagementWebApp.Constants;

namespace LeaveManagementWebApp.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly UserManager<Employee> userManager;
        public LeaveAllocationRepository(ApplicationDbContext context, UserManager<Employee> userManager) : base(context)
        {
            this.userManager = userManager;
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
        }
    }
}
