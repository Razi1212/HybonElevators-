
using Hybon.DataAccess.Database;
using Hybon.Business.Interfaces;
using Hybon.Business.Services;

using Hybon.DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Register controllers
builder.Services.AddControllers();

// Register OpenAPI
builder.Services.AddOpenApi();

//// Register SqlConnectionFactory
//builder.Services.AddSingleton<SqlConnectionFactory>(sp =>
//{
//    var configuration = sp.GetRequiredService<IConfiguration>();

//    var connectionString =
//        configuration.GetConnectionString("HybonConnection");

//    if (string.IsNullOrWhiteSpace(connectionString))
//        throw new InvalidOperationException(
//            "HybonConnection connection string is missing.");

//    return new SqlConnectionFactory(connectionString);
//});

//builder.Services.AddScoped<IAuthService, AuthService>();
//builder.Services.AddScoped<IAuthRepository, AuthRepository>();
//builder.Services.AddScoped<IPasswordService, PasswordService>();

// Build application
var app = builder.Build();

// Configure HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
