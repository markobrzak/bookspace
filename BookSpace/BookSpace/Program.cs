using BookSpace.BusinessLogic;
using BookSpace.BusinessLogic.Interfaces;
using BookSpace.Services;
using BookSpace.Services.Interface;
using Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBookSpaceBusinessLogic, BookSpaceBusinessLogic>();
builder.Services.AddScoped<IBookSpaceService, BookSpaceService>();

builder.Services.AddAutoMapper(typeof(DefaultProfile));

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
