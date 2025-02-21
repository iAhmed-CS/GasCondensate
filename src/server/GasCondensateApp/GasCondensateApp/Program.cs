using Controllers.Controllers;
using Controllers.Persenters;
using Controllers.Presenters;
using Domain;
using Domain.CreateGasCondensate;
using Domain.DeleteGasCondensate;
using Domain.DisplayGasCondensateList;
using Domain.UpdateGasCondensate;
using Gateways;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy(name: "CorsPolicy", builder =>
    {
        builder.WithOrigins("http://localhost:4200")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials();
    });
});

builder.Services.AddTransient<ICreateGasCondensateUseCase, CreateGasCondensateUseCase>();
builder.Services.AddTransient<IDeleteGasCondensateUseCase, DeleteGasCondensateUseCase>();
builder.Services.AddTransient<IUpdateGasCondensateUseCase, UpdateGasCondensateUseCase>();
builder.Services.AddTransient<IDisplayGasCondensateListUseCase, DisplayGasCondensateListUseCase>();
builder.Services.AddTransient<IGasCondensateGateway, InMemoryGasCondensateRepository>();
builder.Services.AddTransient<IActionResultPresenter, RestPresenter>();
builder.Services.AddControllers().AddApplicationPart(typeof(CreateGasCondensateController).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "Gas Condensate App");
    });
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
