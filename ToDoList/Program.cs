using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();

      builder.Services.AddDbContext<ToDoListContext>(
          dbContextOptions => dbContextOptions
          .UseMySql(  // also works for mariadb
              builder.Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                )
            )
          );

      WebApplication app = builder.Build();

    //   app.UseDeveloperExceptionPage();
      app.UseHttpsRedirection();
      app.UseStaticFiles();

      app.UseRouting();

      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );

      app.Run();
    }
  }
}













// using System.IO;
// using Microsoft.AspNetCore.Hosting;

// namespace ToDoList
// {
//   public class Program
//   {
//     public static void Main(string[] args)
//     {
//       var host = new WebHostBuilder()
//         .UseKestrel()
//         .UseContentRoot(Directory.GetCurrentDirectory())
//         .UseIISIntegration()
//         .UseStartup<Startup>()
//         .Build();

//       host.Run();
//     }
//   }
// }
