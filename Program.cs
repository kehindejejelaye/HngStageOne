var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { message = "API is running" }));

app.MapGet("/health", () => Results.Ok(new { message = "healthy" }));

app.MapGet("/me", () => Results.Ok(new { 
    name = "Kehinde Jejelaye", 
    email = "kehindejejelaye@gmail.com", 
    github = "https://github.com/kehindejejelaye" 
}));

app.Run();
