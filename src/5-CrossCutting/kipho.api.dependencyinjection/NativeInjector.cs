using kipho.api.data.Repository;
using kipho.api.domain.Interfaces;
using kipho.api.services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kipho.api.dependencyinjection
{
        public static class NativeInjector
        {
            public static void RegisterDependencies(this IServiceCollection services)
            {
                #region Aplicacao
                services.AddTransient<IProductsServices, ProductsServices>();
                #endregion

                #region Infra
               
                #endregion
            }
        }
}
