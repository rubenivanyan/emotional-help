using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Data.Seeding;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Implementation;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Implementation;
using PsychologicalAssistance.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddDbContext<ApplicationDbContext>(options
                => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<User, IdentityRole>(opts => {
                opts.Password.RequiredLength = 6;
                opts.Password.RequireDigit = true;
                opts.Password.RequireUppercase = true;
                opts.Password.RequireLowercase = true;
                opts.Password.RequireNonAlphanumeric = true;
            }).AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();
            services.ConfigureApplicationCookie(o => o.LoginPath = "/User/Login");
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            #region Repositories
            services.AddScoped(typeof(IDataRepository<>), typeof(DataRepository<>));
            services.AddScoped<ITestRepository, TestRepository>();
            services.AddScoped<IApplicationRepository, ApplicationRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IVariantRepository, VariantRepository>();
            services.AddScoped<ITestResultsRepository, TestResultsRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IFilmRepository, FilmRepository>();
            services.AddScoped<IComputerGameRepository, ComputerGameRepository>();
            services.AddScoped<IMusicRepository, MusicRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<ITrainingRepository, TrainingRepository>();
            services.AddScoped<IConsultingApplicationRepository, ConsultingApplicationRepository>();
            #endregion

            #region Services
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITestService, TestService>();
            services.AddScoped<IApplicationService, ApplicationService>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IVariantService, VariantService>();
            services.AddScoped<ITestResultsService, TestResultsService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IFilmService, FilmService>();
            services.AddScoped<IComputerGameService, ComputerGameService>();
            services.AddScoped<IMusicService, MusicService>();
            services.AddScoped<IMaterialsRecommendationService, MaterialsRecommendationService>();
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<ITrainingService, TrainingService>();
            services.AddScoped<IConsultingApplicationService, ConsultingApplicationService>();
            #endregion

            #region UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PsychologicalAssistance", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            var seedingConfig = Configuration.GetSection("SeedingConfig").Get<SeedingConfig>();
            if (seedingConfig != null && seedingConfig.IsOn)
            {
                using (var serviceScope = serviceProvider.CreateScope())
                {
                    var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                    Initializer.Initialize(dbContext);
                }
            }
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PsychologicalAssistance v1"));

            CreateDefaultAdmin(serviceProvider);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(builder => builder.AllowAnyOrigin());

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void CreateDefaultAdmin(IServiceProvider serviceProvider)
        {
            var UserManager = serviceProvider.GetRequiredService<UserManager<User>>();            
            var user = Task.Run(() => UserManager.FindByEmailAsync("admin@email.com")).Result;
            if (user == null)
            {
                var admin = new User
                {
                    UserName = "Admin",
                    UserSurname = "Admin",
                    Email = "admin@email.com",
                };
                string adminPassword = "Admin1!";
                var result = Task.Run(() => UserManager.CreateAsync(admin, adminPassword)).Result;
                if (result.Succeeded)
                {
                    Task.Run(() => UserManager.AddToRoleAsync(admin, "Administrator"));
                }
            }
        }
    }
}
