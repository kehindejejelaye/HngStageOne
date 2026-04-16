var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Json(new { message = "API is running" }));

app.MapGet("/health", () => Results.Json(new { message = "healthy" }));

app.MapGet("/me", () => Results.Json(new { 
    name = "Kehinde Jejelaye", 
    email = "kehindejejelaye@gmail.com", 
    github = "https://github.com/kehindejejelaye" 
}));

app.Run();
