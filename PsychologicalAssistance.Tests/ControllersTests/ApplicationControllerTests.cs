using AutoMapper;
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
    public class ApplicationControllerTests
    {
        private readonly Mock<IApplicationService> _applicationServiceMock;
        private readonly IMapper _mapper;

        public ApplicationControllerTests()
        {
            _applicationServiceMock = BasicClassForMocking.CreateServiceMock<IApplicationService, Application>();
            _mapper = BasicClassForMocking.ConfigMapper(new ApplicationProfile());
        }

        [Fact]
        public async Task GetAllApplications_ReturnsOkObjectResult_WithListOfApplicationsDtosValue()
        {
            //arrange
            _applicationServiceMock.Setup(x => x.GetAllApplicationsAsync()).ReturnsAsync(() => new List<ApplicationDto>());
            var controller = new ApplicationController(_applicationServiceMock.Object, _mapper);

            //act
            var result = await controller.GetAllApplications() as OkObjectResult;

            //assert
            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(new List<ApplicationDto>(), result.Value);
        }

        [Fact]
        public async Task GetAllApplications_ReturnsNotFoundObjectResult_WithNullValue()
        {
            //arrange
            _applicationServiceMock.Setup(x => x.GetAllApplicationsAsync()).ReturnsAsync(() => null);
            var controller = new ApplicationController(_applicationServiceMock.Object, _mapper);

            //act
            var result = await controller.GetAllApplications() as NotFoundResult;

            //assert
            Assert.NotNull(result);
            Assert.IsType<NotFoundResult>(result);
            Assert.Equal(404, result.StatusCode);
        }
    }
}
