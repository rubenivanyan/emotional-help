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
    public class TestingApplicationServiceTests
    {
        private readonly Mock<ITestingApplicationRepository> _testingApplicationRepositoryMock;
        private readonly Mock<IDataRepository<TestingApplication>> _dataRepositoryMock;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;

        public TestingApplicationServiceTests()
        {
            _testingApplicationRepositoryMock = BasicClassForMocking.CreateRepositoryMock<ITestingApplicationRepository, TestingApplication>();
            _dataRepositoryMock = BasicClassForMocking.CreateRepositoryMock<IDataRepository<TestingApplication>, TestingApplication>();
            _unitOfWorkMock = BasicClassForMocking.CreateMock<IUnitOfWork>();
        }

        [Fact]
        public async Task GetAllApplicationsAsync_ReturnsIEnumerableOfApplicationDto()
        {
            //arrange
            _testingApplicationRepositoryMock.Setup(x => x.GetAllTestingApplicationsDtoAsync()).ReturnsAsync(() => new List<TestingApplicationDto>());
            var testingApplicationService = new TestingApplicationService(_dataRepositoryMock.Object, _unitOfWorkMock.Object, _testingApplicationRepositoryMock.Object);

            //act
            var result = await testingApplicationService.GetAllTestingApplicationsAsync();

            //assert
            Assert.NotNull(result);
            Assert.IsType<List<TestingApplicationDto>>(result);
        }
    }
}
