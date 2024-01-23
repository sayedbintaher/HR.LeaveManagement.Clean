using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Persistence.DatabaseContext;

namespace HR.LeaveManagement.Persistence.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        public LeaveAllocationRepository(HrDatabaseContext context) : base(context)
        {
        }

        public Task AddAllocations(List<LeaveAllocation> allocations)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AllocationExists(string userId, int leaverTypeId, int period)
        {
            throw new NotImplementedException();
        }

        public Task<List<LeaveAllocation>> GetAllLeaveAllocationsWithDetails()
        {
            throw new NotImplementedException();
        }

        public Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveAllocation> GetUserAllocations(string userId, int leaveTypeId)
        {
            throw new NotImplementedException();
        }
    }
}
