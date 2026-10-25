using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Billing.BillingAPI.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// --- 1. CONFIGURAR LA CONEXIÓN A SQL SERVER ---
builder.Services.AddDbContext<BillingDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();