using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder();
var app = builder.Build();


app.UseStaticFiles();//������������ ������� � ������ � ����� wwwroot
app.UseStaticFiles(new StaticFileOptions() // ������������ ������� � �������� wwwroot/html
{
    FileProvider = new PhysicalFileProvider(
            Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\html")),
    RequestPath = new PathString("/pages")
});
app.Run(async (context) => await context.Response.WriteAsync("Hello World"));

app.Run();