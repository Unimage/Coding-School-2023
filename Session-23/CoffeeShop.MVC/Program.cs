using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using CoffeeShop.Orm.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IEntityRepo<ProductCategory>, ProductCategoryRepo>();
builder.Services.AddScoped<IEntityRepo<Product>, ProductRepo>();
builder.Services.AddScoped<IEntityRepo<Employee>, EmployeeRepo>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
