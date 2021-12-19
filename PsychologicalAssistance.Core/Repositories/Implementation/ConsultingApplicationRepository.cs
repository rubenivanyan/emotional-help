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
    public class ConsultingApplicationRepository : DataRepository<ConsultingApplication>, IConsultingApplicationRepository
    {
        private readonly IMapper _mapper;

        public ConsultingApplicationRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<ConsultingApplicationDto>> GetAllConsultingApplicationsDtoAsync()
        {
            var consultingApplications = await GetAllItemsAsync();
            if (consultingApplications == null)
            {
                return null;
            }

            var consultingApplicationsDto = _mapper.Map<IEnumerable<ConsultingApplication>, IEnumerable<ConsultingApplicationDto>>(consultingApplications);
            return consultingApplicationsDto;
        }

        public async Task<ConsultingApplicationDto> GetConsultingApplicationByIdDtoAsync(int id)
        {
            var consultingApplication = await GetItemByIdAsync(id);
            if (consultingApplication == null)
            {
                return null;
            }

            var consultingApplicationDto = _mapper.Map<ConsultingApplication, ConsultingApplicationDto>(consultingApplication);
            return consultingApplicationDto;
        }

        public async Task<IEnumerable<FullConsultingApplicationDto>> GetFullConsultingApplicationsWithUserInfoDtoAsync()
        {
            var consultingApplications = await Task.Run(() => DbSet
                .Include(consultingApplication => consultingApplication.User)
                .Select(consultingApplication => new FullConsultingApplicationDto
                {
                    Id = consultingApplication.Id,
                    ConvenientDay = consultingApplication.ConvenientDay.ToShortDateString(),
                    UserId = consultingApplication.User.Id,
                    UserFullName = consultingApplication.User.UserName + " " + consultingApplication.User.UserSurname,
                    Email = consultingApplication.User.Email,
                }).ToList());

            return consultingApplications;
        }

        public async Task<FullConsultingApplicationDto> GetFullConsultingApplicationWithUserInfoByIdDtoAsync(int id)
        {
            var consultingApplication = await Task.Run(() => DbSet
                .Where(consultingApplication => consultingApplication.Id == id)
                .Include(consultingApplication => consultingApplication.User)
                .Select(consultingApplication => new FullConsultingApplicationDto
                {
                    Id = consultingApplication.Id,
                    ConvenientDay = consultingApplication.ConvenientDay.ToShortDateString(),
                    UserId = consultingApplication.UserId,
                    UserFullName = consultingApplication.User.UserName + " " + consultingApplication.User.UserSurname,
                    Email = consultingApplication.User.Email
                }).FirstOrDefault());

            return consultingApplication;
        }

        public async Task<IEnumerable<FullConsultingApplicationDto>> GetFullConsultingApplicationWithUserInfoByUserIdDtoAsync(string UserId)
        {
            var consultingApplication = await Task.Run(() => DbSet
                .Where(consultingApplication => consultingApplication.UserId == UserId)
                .Include(consultingApplication => consultingApplication.User)
                .Select(consultingApplication => new FullConsultingApplicationDto
                {
                    Id = consultingApplication.Id,
                    ConvenientDay = consultingApplication.ConvenientDay.ToShortDateString(),
                    UserId = consultingApplication.UserId,
                    UserFullName = consultingApplication.User.UserName + " " + consultingApplication.User.UserSurname,
                    Email = consultingApplication.User.Email
                }).ToList());

            return consultingApplication;
        }
    }
}
