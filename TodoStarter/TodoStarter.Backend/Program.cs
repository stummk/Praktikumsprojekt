using Microsoft.EntityFrameworkCore;
using TodoStarter.Backend.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApiDocument(options =>
{
    options.Title = "Todos";
});

builder.Services.AddDbContext<TodoDBContext>(options =>
    options.UseSqlite("Data Source=todo.db"));

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseOpenApi();
app.UseSwaggerUi();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseAuthorization();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
