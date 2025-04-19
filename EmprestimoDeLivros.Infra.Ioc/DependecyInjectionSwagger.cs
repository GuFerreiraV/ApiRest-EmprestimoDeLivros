using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace EmprestimoDeLivros.Infra.Ioc
{
    public static class DependecyInjectionSwagger
    {
        public static IServiceCollection AddInfraestructureSwagger(this IServiceCollection services) {

            services.AddSwaggerGen(c =>
            {

                // Configurando a definição de segurança
                c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme()
                {

                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Json Web Token (JWT)"

                });


                c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement()
                {

                    { 
                        new OpenApiSecurityScheme()
                        { 
                            Reference = new OpenApiReference()
                            { 
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }

                });

            });

            return services;
        }
    }
}
