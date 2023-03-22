using API.Model.DataConnection;
using API.Repository.AdminRepo;
using API.Repository.UserRepo;
using API.Service;
using Microsoft.EntityFrameworkCore;

namespace ProjectAPI.DependencyInjection
{
    public class Dependency
    {
        private readonly static ILoggerFactory _loggerFactory;
        public static void Inject(IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ProjectContext>(x =>
            {
                x.UseSqlServer(connectionString);
                x.UseLoggerFactory(_loggerFactory);
            });

            services.AddAutoMapper(typeof(Program));

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IAdminRepository, AdminRepository>();
            services.AddTransient<UserLoginService>();
        }
    }
}
