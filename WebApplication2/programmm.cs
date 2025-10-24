var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (context) =>
{
    var path = context.Request.Path;
    var now =  DateTime.Now;
    var response = context.Response;

    if (path == "/date")
        await response.WriteAsync($"Date: {now.ToShortDateString()}");
    else if (path == "/time")
        await response.WriteAsync($"Time: {now.ToShortTimeString()}");
    else
        await response.WriteAsync("Hello, my name is Ilya");

});
app.Run();