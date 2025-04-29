
using Microsoft.EntityFrameworkCore;
using SportClub;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

string connStr = builder.Configuration.GetConnectionString("Main");

builder.Services.AddControllers();
builder.Services.AddDbContext<SportClubDbContext>(cfg => 
cfg.UseSqlServer(connStr));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddDbContext<SportClubDbContext>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();