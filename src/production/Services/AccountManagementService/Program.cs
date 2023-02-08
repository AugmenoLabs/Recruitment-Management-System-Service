using AccountManagementService.V1.Interface;
using AccountManagementService.V1.Service;
using Microsoft.EntityFrameworkCore;
using OpenPositionService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var connectionStrings = builder.Configuration.GetConnectionString("conString");
builder.Services.AddDbContext<RecruitmentMgmtSystemDbContext>(options => options.UseNpgsql(connectionStrings));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
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
