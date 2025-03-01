var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles(); // Statik dosyalar için bu satır eklenmeli

app.UseRouting(); // Routing işlemleri

app.UseAuthorization(); // Yetkilendirme

// Default route configuration, HomeController -> Index action
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Favicon ve diğer statik dosyaların doğru şekilde servis edilmesini sağlamak için statik içerikler harici servisler eklenebilir

app.Run();