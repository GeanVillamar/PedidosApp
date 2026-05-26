using Microsoft.EntityFrameworkCore;
using PedidosApp;

var builder = WebApplication.CreateBuilder(args);

// Add Db context

var dbProvider = builder.Configuration.GetConnectionString("Provider");

builder.Services.AddDbContext<DataContext>(options =>
{

    if (dbProvider == "SqlServer")
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnectionString"));
    }
    else if (dbProvider == "Sqlite")
    {
        options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnectionString"));
    }
});


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//github actions comments test

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
