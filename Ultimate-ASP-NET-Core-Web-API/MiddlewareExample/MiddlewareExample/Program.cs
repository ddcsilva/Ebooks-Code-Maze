var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.Use(async (context, next) =>
{
    Console.WriteLine($"Logica antes de executar o delegate Next no metodo Use");
    await next.Invoke();
    Console.WriteLine($"Logica depois de executar o delegate Next no metodo Use");
});

app.Run(async context =>
{
    Console.WriteLine($"Exibindo a resposta para o cliente no metodo Run");
    await context.Response.WriteAsync("Componente Middleware dizendo um Oi!");
});

app.MapControllers();

app.Run();
