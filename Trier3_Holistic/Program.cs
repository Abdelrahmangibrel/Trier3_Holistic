using Microsoft.EntityFrameworkCore;
using Trier3_Holistic.AppDbContext;
using Trier3_Holistic.Repositorys.RepoREaction;
using Trier3_Holistic.Repositorys.RepoUser;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connection = builder.Configuration.GetConnectionString("myconnection");
builder.Services.AddDbContext<dbcontext>(options => options.UseSqlServer(connection));


builder.Services.AddControllers();

builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IReactionRepo, ReactionRepo>();


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
