using APS_proyecto.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// builder.Services.AddDbContext<EscuelaContext>(options => options.UseInMemoryDatabase(databaseName:"TestDB")); // Tomado del curso de EF conecxion a base de datos
string connString = ConfigurationExtensions.GetConnectionString(this.Configuration, "DefaultConnectionString");
builder.Services.AddDbContext<EscuelaContext>(options => options.UseSqlServer(connString)); // Tomado del curso de EF conecxion a base de datos

var app = builder.Build();

// Get Ensured the database has created in memory

using(var scope=app.Services.CreateScope()) // the word using to eliminated the variable after executing the program.
{
    var serv=scope.ServiceProvider;
    try
    {
        var contex=serv.GetRequiredService<EscuelaContext>();
        contex.Database.EnsureCreated();
    }
    catch (System.Exception)
    {
        throw;
    }

}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Escuela}/{action=Index}/{id?}");

app.Run();
