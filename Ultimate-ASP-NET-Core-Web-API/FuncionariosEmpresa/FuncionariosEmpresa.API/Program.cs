using FuncionariosEmpresa.API.Extensions;
using FuncionariosEmpresa.Presentation;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;

var builder = WebApplication.CreateBuilder(args);

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

builder.Services.ConfigurarCORS();
builder.Services.ConfigurarIntegracaoIIS();
builder.Services.ConfigurarServicoLogger();
builder.Services.ConfigurarGerenciadorRepository();
builder.Services.ConfigurarGerenciadorRepository();
builder.Services.ConfigurarGerenciadorService();
builder.Services.ConfigurarContextoSQL(builder.Configuration);

builder.Services.AddControllers().AddApplicationPart(typeof(AssemblyReference).Assembly);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
