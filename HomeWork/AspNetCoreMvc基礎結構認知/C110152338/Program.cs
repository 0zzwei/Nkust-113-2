using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Services;

namespace WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // �[�J MVC �A��
            builder.Services.AddControllersWithViews();

            // ���U Rescue �����A��
            builder.Services.AddScoped<IRescueService, RescueService>();

            // �[�J DbContext�]��Ʈw�s�u�^
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            // �ҥ~�B�z�P�w���ʳ]�w
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles(); // �T�O��B�z wwwroot �����R�A�귽

            app.UseRouting();
            app.UseAuthorization();

            // �]�w����
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Rescue}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
