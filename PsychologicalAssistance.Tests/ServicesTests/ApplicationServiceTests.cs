using Moq;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Implementation;
using PsychologicalAssistance.Tests.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace PsychologicalAssistance.Tests.ServicesTests
{
    public class ApplicationServiceTests
    {
        private readonly Mock<IApplicationRepository> _applicationRepositoryMock;
        private readonly Mock<IDataRepository<Application>> _dataRepositoryMock;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;

        public ApplicationServiceTests()
        {
            _applicationRepositoryMock = BasicClassForMocking.CreateRepositoryMock<IApplicationRepository, Application>();
            _dataRepositoryMock = BasicClassForMocking.CreateRepositoryMock<IDataRepository<Application>, Application>();
            _unitOfWorkMock = BasicClassForMocking.CreateMock<IUnitOfWork>();
        }

        [Fact]
        public async Task GetAllApplicationsAsync_ReturnsIEnumerableOfApplicationDto()
        {
            //arrange
            _applicationRepositoryMock.Setup(x => x.GetAllApplicationsDtoAsync()).ReturnsAsync(() => new List<ApplicationDto>());
            var applicationService = new ApplicationService(_dataRepositoryMock.Object, _unitOfWorkMock.Object, _applicationRepositoryMock.Object);

            //act
            var result = await applicationService.GetAllApplicationsAsync();

            //assert
            Assert.NotNull(result);
            Assert.IsType<List<ApplicationDto>>(result);
        }
    }
}
