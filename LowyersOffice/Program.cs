using LowyersOffice;
using Office.Core.Repository;
using Office.Core.Services;
using Office.Data;
using Office.Data.Repository;
using Office.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICostumerRepository, CostumerRepository>();
builder.Services.AddScoped<ICourtCaseRepository, CourtCaseRepository>();
builder.Services.AddScoped<IIncomesRepository, IncomesRepository>();

builder.Services.AddScoped<ICostumerService, CostumerService>();
builder.Services.AddScoped<ICourtCaseService, CourtCaseService>();
builder.Services.AddScoped<IIncomeService, IncomeService>();

builder.Services.AddScoped<DataContext>();

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
