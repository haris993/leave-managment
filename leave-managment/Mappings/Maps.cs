using AutoMapper;
using leave_managment.Data;
using leave_managment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_managment.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, EditLeaveAllocationVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();


        }
    }
}
