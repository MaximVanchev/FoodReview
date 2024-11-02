//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;
//using MyArtPlace.Areas.Identity.Data;
//using MyArtPlace.Core.Contracts;
////using MyArtPlace.Core.Models.Mail;
//using MyArtPlace.Core.Services;
//using MyArtPlace.Data;
//using MyArtPlace.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using FoodReview.Infrastructure.Data;
using FoodReview.Infrastructure.Data.Repositories;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IApplicationDbRepository, ApplicationDbRepository>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContexts(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<FoodReviewContext>(options =>
                options.UseSqlServer(connectionString));
            //services.Configure<MailSettings>(config.GetSection("MailSettings"));

            return services;
        }
    }
}