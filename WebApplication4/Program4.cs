var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (context) =>
{
    Person ilya = new("Ilya", 17, "Вологодский колледж связи");
    await context.Response.WriteAsJsonAsync(ilya);
    
});

app.Run();

public record Person(string Name, int Age, string college);