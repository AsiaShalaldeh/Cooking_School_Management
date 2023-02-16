////var builder = WebApplication.CreateBuilder(args);

////// Add services to the container.
////builder.Services.AddRazorPages();

////var app = builder.Build();

////// Configure the HTTP request pipeline.
////if (!app.Environment.IsDevelopment())
////{
////    app.UseExceptionHandler("/Error");
////    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
////    app.UseHsts();
////}

////app.UseHttpsRedirection();
////app.UseStaticFiles();

////app.UseRouting();

////app.UseAuthorization();

////app.MapRazorPages();

////app.Run();

using Microsoft.EntityFrameworkCore;
using CookingSchoolManagement.Data;
using CookingSchoolManagement.Services;
using CookingSchoolManagement.Interfaces;

WebApplicationBuilder webAppBuilder = WebApplication.CreateBuilder(args);


webAppBuilder.Services.AddDbContext<SchoolContext>(x =>
x.UseSqlServer(webAppBuilder.Configuration.GetConnectionString("MyConn")));

webAppBuilder.Services.AddScoped<IAdminService, AdminService>();
webAppBuilder.Services.AddScoped<ICourseService, CourseService>();
webAppBuilder.Services.AddEndpointsApiExplorer();

webAppBuilder.Services.AddControllers();
WebApplication app = webAppBuilder.Build();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.Run("http://localhost:5500");