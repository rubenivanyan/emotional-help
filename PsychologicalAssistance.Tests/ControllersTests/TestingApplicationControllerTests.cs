using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Data.Helpers.AutoMapper;
using PsychologicalAssistance.Services.Interfaces;
using PsychologicalAssistance.Tests.Common;
using PsychologicalAssistance.Web.Controllers;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace PsychologicalAssistance.Tests.ControllersTests
{
    public class TestingApplicationControllerTests
    {
        private readonly Mock<ITestingApplicationService> _testingApplicationServiceMock;
        private readonly Mock<UserManager<User>> _userManagerMock;
        private readonly IMapper _mapper;

        public TestingApplicationControllerTests()
        {
            _testingApplicationServiceMock = BasicClassForMocking.CreateServiceMock<ITestingApplicationService, TestingApplication>();
            _userManagerMock = BasicClassForMocking.CreateUserManagerMock<User>();
            _mapper = BasicClassForMocking.ConfigMapper(new TestingApplicationProfile());
        }

        [Fact]
        public async Task GetAllApplications_ReturnsOkObjectResult_WithListOfApplicationsDtosValue()
        {
            //arrange
            _testingApplicationServiceMock.Setup(x => x.GetAllTestingApplicationsAsync()).ReturnsAsync(() => new List<TestingApplicationDto>());
            var controller = new TestingApplicationController(_mapper, _testingApplicationServiceMock.Object, _userManagerMock.Object);

            //act
            var result = await controller.GetAllTestingApplications() as OkObjectResult;

            //assert
            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(new List<TestingApplicationDto>(), result.Value);
        }

        [Fact]
        public async Task GetAllApplications_ReturnsNotFoundResult_WithNullValue()
        {
            //arrange
            _testingApplicationServiceMock.Setup(x => x.GetAllTestingApplicationsAsync()).ReturnsAsync(() => null);
            var controller = new TestingApplicationController(_mapper, _testingApplicationServiceMock.Object, _userManagerMock.Object);

            //act
            var result = await controller.GetAllTestingApplications() as NotFoundResult;

            //assert
            Assert.NotNull(result);
            Assert.IsType<NotFoundResult>(result);
            Assert.Equal(404, result.StatusCode);
        }
    }
}
