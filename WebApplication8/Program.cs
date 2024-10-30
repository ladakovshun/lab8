using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplication8.Services;

var builder = WebApplication.CreateBuilder(args);

// ������ ����� MVC
builder.Services.AddControllersWithViews();

// �������� ����� ProductService
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

// ������������ ���������� ���������
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ������������ �������������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();

