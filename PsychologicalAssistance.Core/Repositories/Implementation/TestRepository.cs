using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
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

            var testDto = _mapper.Map<Test, TestDto>(test);
            return testDto;
        }

        public async Task<IEnumerable<TestDto>> GetAllTestsDtoAsync()
        {
            var tests = await GetAllItemsAsync();
            if (tests == null)
            {
                return null;
            }

            var testsDto = _mapper.Map<IEnumerable<Test>, IEnumerable<TestDto>>(tests);
            return testsDto;
        }

        public async Task<IEnumerable<FullTestDto>> GetAllTestsWithQuestionsDtoAsync()
        {
            var tests = await Task.Run(() => DbSet.Select(test => new FullTestDto
            {
                Id = test.Id,
                Title = test.Title,
                TypeOfTest = test.TypeOfTest,
                Questions = test.Questions.Select(q => new FullQuestionDto
                {
                    Id = q.Id,
                    ImageUrl = q.ImageUrl,
                    Formulation = q.Formulation,
                    Variants = _mapper.Map<IEnumerable<Variant>, IEnumerable<VariantDto>>(q.Variants).ToList()
                }).ToList()
            }));

            return tests;
        }

        public async Task<FullTestDto> GetTestWithQuestionsByIdDtoAsync(int id)
        {
            var test = await Task.Run(() => DbSet.Where(t => t.Id == id).Include(t => t.Questions).ThenInclude(v => v.Variants).Select(t => new FullTestDto
            {
                Id = t.Id,
                Title = t.Title,
                TypeOfTest = t.TypeOfTest,
                Questions = t.Questions.Select(q => new FullQuestionDto
                {
                    Id = q.Id,
                    ImageUrl = q.ImageUrl,
                    Formulation = q.Formulation,
                    Variants = _mapper.Map<IEnumerable<Variant>, IEnumerable<VariantDto>>(q.Variants).ToList()
                }).ToList()
            }).FirstOrDefaultAsync());

            return test;
        }
    }
}
