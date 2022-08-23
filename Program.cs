using apiTienda;



var builder = WebApplication.CreateBuilder(args);
var Startup = new Startup(builder.Configuration);
Startup.ConfigureServices(builder.Services);
var app = builder.Build();
var ServicioIlogger=(ILogger<Startup>) app.Services.GetService(typeof(ILogger<Startup>));
Startup.Configure(app, app.Environment,ServicioIlogger);
app.Run();
