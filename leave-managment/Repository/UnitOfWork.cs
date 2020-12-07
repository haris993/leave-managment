using leave_managment.Contracts;
using leave_managment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_managment.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly IGenericRepository<LeaveType> _leaveTypes;
        private readonly IGenericRepository<LeaveRequest> _leaveRequests;
        private readonly IGenericRepository<LeaveAllocation> _leaveAllocations;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<LeaveType> LeaveTypes { get => _leaveTypes == null ? _leaveTypes : new GenericRepository<LeaveType>(_context); }
        public IGenericRepository<LeaveRequest> LeaveRequests { get => _leaveRequests == null ? _leaveRequests : new GenericRepository<LeaveRequest>(_context); }
        public IGenericRepository<LeaveAllocation> LeaveAllocations { get => _leaveAllocations == null ? _leaveAllocations : new GenericRepository<LeaveAllocation>(_context); }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool dispose)
        {
            if (dispose)
            {
                _context.Dispose();
            }
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
