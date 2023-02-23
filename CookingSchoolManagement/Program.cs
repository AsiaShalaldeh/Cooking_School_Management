using Microsoft.EntityFrameworkCore;
using CookingSchoolManagement.Data;
using CookingSchoolManagement.Services;
using CookingSchoolManagement.Interfaces;

WebApplicationBuilder webAppBuilder = WebApplication.CreateBuilder(args);


webAppBuilder.Services.AddDbContext<SchoolContext>(x =>
x.UseSqlServer(webAppBuilder.Configuration.GetConnectionString("MyConn")));

webAppBuilder.Services.AddScoped<IAdminService, AdminService>();
webAppBuilder.Services.AddScoped<ICourseService, CourseService>();
webAppBuilder.Services.AddScoped<IStudentService, StudentService>();
webAppBuilder.Services.AddScoped<IClassService, ClassService>();
webAppBuilder.Services.AddScoped<ITeacherService, TeacherService>();
webAppBuilder.Services.AddScoped<IFavoritesService, FavoritesService>();
webAppBuilder.Services.AddEndpointsApiExplorer();

webAppBuilder.Services.AddControllers();
WebApplication app = webAppBuilder.Build();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();


app.Run("http://localhost:5500");