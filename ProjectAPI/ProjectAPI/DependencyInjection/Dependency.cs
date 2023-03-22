using API.Model.DataConnection;
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

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<UserLoginService>();
        }
    }
}
