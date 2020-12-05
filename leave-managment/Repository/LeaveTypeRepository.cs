using leave_managment.Contracts;
using leave_managment.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_managment.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db; 
        }

        public async Task<bool> Create(LeaveType entity)
        {
            await _db.LeaveTypes.AddAsync(entity);
            // Save
            return await Save();
        }

        public async Task<bool> Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            // Save
            return await Save();
        }

        public async Task<ICollection<LeaveType>> FindAll()
        {
            var leaveTypes = await _db.LeaveTypes.ToListAsync();
            return leaveTypes;
        }

        public async Task<LeaveType> FindById(int id)
        {
            var leaveType = await _db.LeaveTypes.FindAsync(id);
            return leaveType;
        }

        public async Task<bool> isExists(int id)
        {
            var exists = await _db.LeaveTypes.AnyAsync(q => q.Id == id);
            return exists;
        }

        public async Task<bool> Save()
        {
            var changes = await _db.SaveChangesAsync();
            return changes > 0;
            //return _db.SaveChanges() > 0;
        }

        public async Task<bool> Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            // Save
            return await Save();
        }
    }
}
