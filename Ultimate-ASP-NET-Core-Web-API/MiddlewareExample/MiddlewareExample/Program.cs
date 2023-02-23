var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.Run(async context =>
{
    await context.Response.WriteAsync("Componente Middleware dizendo um Oi!");
});

app.MapControllers();

app.Run();
