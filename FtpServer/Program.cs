using Ftp.DataLayer.Contex;
using Ftp.InterfaceService.InterfacesBase;
using Ftp.Service.ServiceBase;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var MySQlFtp = builder.Configuration.GetConnectionString("AppDbFTP");
builder.Services.AddDbContext<ContextFTP>(
    x => x.UseMySql(MySQlFtp, ServerVersion.AutoDetect(MySQlFtp)).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<IUnitOfWorkFtpService, UnitOfWorkFtpService>();


builder.Services.AddGrpc();
builder.Services.AddGrpcReflection();

var app = builder.Build();


app.UseHttpsRedirection();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGrpcService<FtpServer.FtpService.FtpService>();
});

app.MapGet("/", () => "Hello World!");

app.Run();


