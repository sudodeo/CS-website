using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using CS_website.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddEntityFrameworkNpgsql()
.AddDbContext<CourseContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("CourseLibraryDB"));
});

// Get the IServiceCollection instance from the builder
var services = builder.Services;

// Add the hosted service and scoped service to the service collection
services.AddScoped<SeedService>();

var app = builder.Build();


// Migrate database and seed data on application startup
using (var scope = app.Services.CreateScope())
{
    var scopeServices = scope.ServiceProvider;
    var context = scopeServices.GetRequiredService<CourseContext>();
    context.Database.Migrate();
    context.Seed();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

public class SeedService : IHostedService
{
    private readonly CourseContext _db;

    public SeedService(CourseContext db)
    {
        _db = db;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _db.Database.Migrate();
        _db.Seed();
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}