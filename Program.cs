using Microsoft.EntityFrameworkCore;
using TrainingCSharp.Repositories;
using TrainingCSharp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Add DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IDeliveryRepository, DeliveryRepository>();

var app = builder.Build();

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
app.MapGet("/", context =>
    {
        context.Response.Redirect("/delivery-search");
        return Task.CompletedTask;
    });
    
app.MapControllerRoute(
    name: "default",
    pattern: "delivery-search/{action=IndexDeliverySearch}/{id?}",
    defaults: new { controller = "Delivery" });

app.Run();
