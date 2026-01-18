var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//get
app.MapGet("/", () => "Hello World!");

app.Run();
