using Microsoft.EntityFrameworkCore;
using P01DAW_2022DC650_2021RJ650_Reservas.Data;
using P01DAW_2022DC650_2021RJ650_Reservas.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ParqueosDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ParqueosDB"))
);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
