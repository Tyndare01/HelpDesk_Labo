using API_HelpDesk_Labo.Hubs;
using DAL.Repositories;
using DAL.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSignalR();
builder.Services.AddSingleton<TicketHub>();
builder.Services.AddScoped<BLL.Repositories.IUserRepositoryBLL, BLL.Services.UserServiceBLL>();
builder.Services.AddScoped<IUserRepository, UserService>();
builder.Services.AddScoped<BLL.Repositories.ITicketRepository, BLL.Services.TicketService>();
builder.Services.AddScoped<ITicketRepository, TicketService>(sp =>
new TicketService(
    new System.Data.SqlClient.SqlConnection(
        builder.Configuration.GetConnectionString("default"))));

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
