using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args); // ✅ Ensure this exists

// ✅ Enable CORS (Cross-Origin Requests)
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://localhost:4200")
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

// ✅ Register Controllers
builder.Services.AddControllers();

var app = builder.Build(); // ✅ Ensure this exists

// ✅ Enable middleware
app.UseCors(MyAllowSpecificOrigins); // Allow frontend to call API
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();
