using AutoMapper;
using Moq;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Interfaces;

namespace PsychologicalAssistance.Tests.Common
{
    public static class BasicClassForMocking
    {
        public static Mock<TService> CreateServiceMock<TService, TEntity>()
                where TService : class, IBaseService<TEntity>
                where TEntity : BaseEntity
            => new Mock<TService>();

        public static Mock<TRepository> CreateRepositoryMock<TRepository, TEntity>()
                where TRepository : class, IDataRepository<TEntity>
                where TEntity : BaseEntity
            => new Mock<TRepository>();

        public static IMapper ConfigMapper(params Profile[] profiles)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                foreach (Profile profile in profiles)
                {
                    mc.AddProfile(profile);
                }
            });

            return mappingConfig.CreateMapper();
        }
    }
}
