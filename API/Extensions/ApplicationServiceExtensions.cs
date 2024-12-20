using System;
using API.Data;
using API.Helpers;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
 public static IServiceCollection AddAplicationServices(this IServiceCollection services,
  IConfiguration config)
 {
    services.AddControllers();
    services.AddDbContext<DataContext>(opt=>
    {
      opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
    });
    services.AddCors();
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
    services.AddScoped<ITokenService, TokenService>();
    services.AddScoped<IUserRepository, UserRepositoy>();
    services.AddScoped<IPhotoService, PhotoService>();
    services.AddScoped<LogUserActivity>();
    services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    services.Configure<CloudinarySettings>(config.GetSection("CloudinarySettings"));

    return services;
 }
}
