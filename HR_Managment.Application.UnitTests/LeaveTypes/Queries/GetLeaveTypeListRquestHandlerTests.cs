using AutoMapper;
using HR_Managment.Application.Contracts.Persistence;
using HR_Managment.Application.DTOs.LeaveType;
using HR_Managment.Application.Features.LeaveType.Handlers.Queries;
using HR_Managment.Application.Features.LeaveType.Requests.Queries;
using HR_Managment.Application.Profiles;
using Moq;
using Shouldly;
using mocksMockRepo= HR_Managment.Application.UnitTests.Mocks.MockRepository;
namespace HR_Managment.Application.UnitTests.LeaveTypes.Queries
{
    public class GetLeaveTypeListRquestHandlerTests
    {
        private IMapper _mapper;
        private Mock<ILeaveTypeRepository> _mockRepository;

        public GetLeaveTypeListRquestHandlerTests()
        {
            _mockRepository = mocksMockRepo.GetLeaveTypeRepository();
            var mapperConfig = new MapperConfiguration(m =>
            {
                m.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
        }

        [Fact]
        public async Task GetLeaveTypeListTest()
        {
            var handler= new GetLeaveTypeListRequestHandler(_mockRepository.Object,_mapper);
            var res = await handler.Handle(new GetLeaveTypeListRequest(),CancellationToken.None);
            res.ShouldBeOfType<List<LeaveTypeDto>>();
            res.Count.ShouldBe(2);
        }
    }
}
