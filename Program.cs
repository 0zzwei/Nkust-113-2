using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenDataAnalyzerMvc.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// 註冊 BIG5 編碼支援
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

// 加入 MVC 服務
builder.Services.AddControllersWithViews();

// 註冊 ElderCareService
builder.Services.AddSingleton<ElderCareService>();

var app = builder.Build();

// 使用靜態檔案和路由
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// 預設路由指向 ElderCareController
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ElderCare}/{action=Index}/{id?}");

app.Run();
