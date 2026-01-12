using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UsuariosApi.data;
using UsuariosApi.Modelos;
using UsuariosApi.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<UsuarioDbContext>(opts =>
{
    opts.UseMySql
    (builder.Configuration.GetConnectionString
    ("UsuarioConnection"), 
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString
    ("UsuarioConnection")
        ));
});
builder.Services.AddAutoMapper
    (AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddIdentity<Usuario, IdentityRole>()
    .AddEntityFrameworkStores<UsuarioDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<CadastroService>();





builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
