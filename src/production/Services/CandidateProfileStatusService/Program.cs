using CandidateProfileStatusService.V1.Services;
using CandidateProfileStatusService.V1.Interfaces;
using OpenPositionService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var connectionStrings = builder.Configuration.GetConnectionString("conString");
builder.Services.AddDbContext<RecruitmentMgmtSystemDbContext>(options => options.UseNpgsql(connectionStrings));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICandidateProfileStatusService,CandidateProfileStatusServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
