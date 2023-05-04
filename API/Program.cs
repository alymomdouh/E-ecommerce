using Core.Interfaces;
using Infrastrucure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<StoreContext>(opt =>
            {
                opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddScoped<IProductRepository, ProductRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            // seed default data 
            using var scope = app.Services.CreateScope();
            var Services = scope.ServiceProvider;
            var context = Services.GetRequiredService<StoreContext>();
            //var identityContext = Services.GetRequiredService<AppIdentityDbContext>();
           // var userManager = Services.GetRequiredService<UserManager<AppUser>>();
            var Logger = Services.GetRequiredService<ILogger<Program>>();

            try
            {
                await context.Database.MigrateAsync();
                //await identityContext.Database.MigrateAsync();
                await StoreContextSeed.SeedAsync(context);
                //await AppIdentityDbContextSeed.SeedUserAsync(userManager);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Error occured while migrating process");
            }
            app.Run();
        }
    }
}