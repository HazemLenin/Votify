using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Votify.Domain.Entities;
using Votify.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Votify.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            var assembly = typeof(DependencyInjection).Assembly;

            services.AddDbContext<VotifyContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddIdentityCore<User>(options => options.SignIn.RequireConfirmedAccount = false)
            .AddEntityFrameworkStores<VotifyContext>();

            return services;
        }
    }
}
