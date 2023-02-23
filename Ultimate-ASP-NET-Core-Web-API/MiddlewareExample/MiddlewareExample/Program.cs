var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Componente Middleware dizendo um Oi!");
    await next.Invoke();
    Console.WriteLine($"Logica depois de executar o delegate Next no metodo Use");
});

app.Map("/usingmapbranch", builder =>
{
    builder.Use(async (context, next) =>
    {
        Console.WriteLine("A logica do Map no m�todo Use antes do pr�ximo delegate");
        await next.Invoke();
        Console.WriteLine("A logica do Map no m�todo Use depois do pr�ximo delegate");
    });
    builder.Run(async context =>
    {
        Console.WriteLine($"A resposta do Map para o cliente no m�todo Run");
        await context.Response.WriteAsync("Saudacoes do Map");
    });
});

app.MapWhen(context => context.Request.Query.ContainsKey("testquerystring"), builder
=>
{
    builder.Run(async context =>
    {
        await context.Response.WriteAsync("Saudacoes do MapWhen");
    });
});

app.Run(async context =>
{
    Console.WriteLine($"Exibindo a resposta para o cliente no metodo Run");
    context.Response.StatusCode = 200;
    await context.Response.WriteAsync("Componente Middleware dizendo um Oi!");
});

app.MapControllers();

app.Run();
