using Microsoft.EntityFrameworkCore;
using NoteControlNet8.Data;
using NoteControlNet8.Mapper;
using NoteControlNet8.Repository.Interface;
using NoteControlNet8.Repository.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Add SqlServer connection
var connectionStrig = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionStrig));

//Add repositories
builder.Services.AddScoped<ISubject, SubjectService>();

//Add AutoMapper
builder.Services.AddAutoMapper(typeof(NoteControlMapper));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
