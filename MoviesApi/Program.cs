using MovieApi.Core.Service;
using MovieApi.Core.Service.Impl;
using MoviesApi.Adapter.Model.Setting;
using MoviesApi.Adapter.Repository;
using MoviesApi.Core.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add dependencie injection to the container.
builder.Services.AddScoped<IUpsertMovie, UpsertMovie>();
builder.Services.AddTransient<IMovieRepository, MovieRepository>();

// Add MongoDB Settings
builder.Services.Configure<MovieStoreDatabaseSettings>(
    builder.Configuration.GetSection("MovieStoreDatabase")
);
builder.Services.AddSingleton<MovieRepository>();

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
