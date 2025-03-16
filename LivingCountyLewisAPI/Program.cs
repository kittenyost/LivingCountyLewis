using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// ✅ ADD CORS POLICY (Update the allowed origin)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy => policy.WithOrigins("http://localhost:4200") // ✅ Allow Angular App
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());  // ✅ Ensure credentials are allowed
});

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "LivingCountyLewisAPI", Version = "v1" });
});

var app = builder.Build();

// ✅ ENABLE CORS BEFORE AUTHORIZATION
app.UseCors("AllowAngular");

if (app.Environment.IsDevelopment()) // ✅ Ensure Swagger is enabled in development mode
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "LivingCountyLewisAPI v1");
    });
}

app.UseAuthorization();
app.MapControllers();
app.Run();