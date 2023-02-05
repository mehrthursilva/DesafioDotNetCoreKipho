using kipho.api.dependencyinjection;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.RegisterDependencies();
builder.Services.ConfigureDependenciesRepository();
    
// Add services the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Teste para Kipho",
                    Description = "Arquitetura DDD",
                    TermsOfService = new Uri("https://www.linkedin.com/in/mehrthur-silva-2528161b1"),
                    Contact = new OpenApiContact
                    {
                        Name = "Mehrthur Luís Lemos da Silva",
                        Email = "mehrthurfordevtools@gmail.com",
                        Url = new Uri("https://www.linkedin.com/in/mehrthur-silva-2528161b1")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Termo de Licença de Uso",
                        Url = new Uri("https://www.linkedin.com/in/mehrthur-silva-2528161b1")
                    }
                });
            });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api Product kipho com AspNetCore 6");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
