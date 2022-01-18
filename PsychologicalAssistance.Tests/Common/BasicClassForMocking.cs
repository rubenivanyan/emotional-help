using AutoMapper;
using Microsoft.AspNetCore.Identity;
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

        public static Mock<UserManager<TUser>> CreateUserManagerMock<TUser>()
                where TUser : class
        {
            var store = new Mock<IUserStore<TUser>>();
            var manager = new Mock<UserManager<TUser>>(store.Object, null, null, null, null, null, null, null, null);
            manager.Object.UserValidators.Add(new UserValidator<TUser>());
            manager.Object.PasswordValidators.Add(new PasswordValidator<TUser>());
            return manager;
        }

        public static Mock<T> CreateMock<T>()
                where T : class
            => new Mock<T>();

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
