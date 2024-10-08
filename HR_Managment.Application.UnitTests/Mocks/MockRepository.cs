using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Managment.Application.Contracts.Persistence;
using HR_Managment.Domain.Models;
using Moq;

namespace HR_Managment.Application.UnitTests.Mocks
{
    public static class MockRepository
    {
        public static Mock<ILeaveTypeRepository> GetLeaveTypeRepository()
        {
            var leaveTypes = new List<LeaveType>()
            {
                new LeaveType
                {
                    Id = 1,
                    DefaultDay = 10,
                    CreatedDateTime = DateTime.Now,
                    Name = "Test Vacation"
                },
                new LeaveType
                {
                    Id = 2,
                    DefaultDay = 20,
                    CreatedDateTime = DateTime.Now,
                    Name = "Test Vacation 2"
                },
            };
            var mockRepo = new Mock<ILeaveTypeRepository>();
            
            mockRepo.Setup(r => r.GetAll()).ReturnsAsync(leaveTypes);//if they call getAll method of repository it get data from here leaveTypes not database 


            mockRepo.Setup(r => r.Add(It.IsAny<LeaveType>())).ReturnsAsync((LeaveType leaveType)=>
            {
                leaveTypes.Add(leaveType);
                return leaveType; 
            });//when we call add method it doesn't add data to database


            return new Mock<ILeaveTypeRepository>();
        }
    }
}
