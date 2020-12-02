using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using leave_managment.Models;

namespace leave_managment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveHistory> LeaveHistories { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        public DbSet<leave_managment.Models.LeaveTypeVM> DetailsLeaveTypeVM { get; set; }
        public DbSet<leave_managment.Models.EmployeeVM> EmployeeVM { get; set; }
        public DbSet<leave_managment.Models.LeaveAllocationVM> LeaveAllocationVM { get; set; }
        public DbSet<leave_managment.Models.EditLeaveAllocationVM> EditLeaveAllocationVM { get; set; }

    }
}
