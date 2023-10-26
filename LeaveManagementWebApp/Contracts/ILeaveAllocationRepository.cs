﻿using LeaveManagementWebApp.Data;
using LeaveManagementWebApp.Models;

namespace LeaveManagementWebApp.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);

        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);

        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int Id);

        Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);
    }
}
