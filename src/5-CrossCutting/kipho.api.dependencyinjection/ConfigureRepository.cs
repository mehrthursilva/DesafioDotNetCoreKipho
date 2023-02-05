using kipho.api.data.Context;
using kipho.api.data.Repository;
using kipho.api.domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kipho.api.dependencyinjection
{
    public static class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            serviceCollection.AddDbContext<MyContext>(
                options => options.UseSqlServer("Server='127.0.0.1';Database='SalesKipho';User ID='SA';Password='A&VeryComplex123Password';Integrated Security=false;Trust Server Certificate=true")
            );
        }
    }
}
