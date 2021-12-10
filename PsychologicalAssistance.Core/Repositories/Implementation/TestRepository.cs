using AutoMapper;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Implementation
{
    public class TestRepository : DataRepository<Test>, ITestRepository
    {
        private readonly IMapper _mapper;
        public TestRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<TestDto> GetTestByIdDtoAsync(int id)
        {
            var test = await GetItemByIdAsync(id);
            if (test == null)
            {
                return null;
            }

            var testDto = _mapper.Map<TestDto>(test);
            return testDto;
        }

        public async Task<IEnumerable<TestDto>> GetAllTestsDtoAsync()
        {
            var tests = await GetAllItemsAsync();
            if (tests == null)
            {
                return null;
            }

            var testsDto = new List<TestDto>();
            foreach (var test in tests)
            {
                testsDto.Add(_mapper.Map<Test, TestDto>(test));
            }

            return testsDto;
        }
    }
}
