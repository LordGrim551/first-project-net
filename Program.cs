using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models; // Necesario para opciones avanzadas de Swagger

var builder = WebApplication.CreateBuilder(args);

// Registrar servicios para MVC + API
builder.Services.AddControllersWithViews();

// Registrar servicios
builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware
// Sirve archivos estáticos desde wwwroot (CSS, JS, imágenes)
app.UseStaticFiles();
// Agrega el middleware de routing para poder mapear rutas a controladores
app.UseRouting();
// Middleware de autorización (aunque no tengas autenticación configurada, se deja por si luego agregas)
app.UseAuthorization();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



// Rutas para API
// Esto hace que los controllers que tengan [ApiController] respondan a /api/...
app.MapControllers();

// Rutas para vistas
// Mapear rutas para controladores MVC (vistas)
// Patrón: {controller}/{action}/{id?}
// Por defecto: HomeController.Index()
// El {id?} es opcional
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
// Inicia la aplicación y empieza a escuchar solicitudes HTTP
app.Run();
