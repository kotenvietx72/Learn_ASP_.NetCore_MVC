﻿var builder = WebApplication.CreateBuilder(args);

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

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index1}/{id?}");

app.MapControllerRoute( // Tạo riêng 1 đường dẫn cho controller Hello, action Welcome
    name: "Hello",
    pattern: "{controller=Home}/{action=Index1}/{name}/{id?}");
// Đi hết 2 tuyến đường, không tìm đc tuyến đường khớp sẽ báo lỗi trình duyệt
app.MapControllerRoute( 
    name: "BTVN1",
    pattern: "{controller=Bai1}/{action}/{x}/{y}/{z}");
app.Run();
