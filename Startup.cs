
using apiTienda.Filtros;
using apiTienda.IServicios;
using apiTienda.Middelwares;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
namespace apiTienda
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(
                options =>
                options.Filters.Add(typeof(FilterExceptions))
            );

            services.AddDbContext<AplicationDbContext>(option => option.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));
            /* builder.Services.AddDbContext<AplicationDbContext>(option =>option.UseSqlServer(confi)) */
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            services.AddEndpointsApiExplorer();
            services.AddTransient<IServicio, ServicioA>();
            //services.AddTransient<IServicio>();

            services.AddTransient<ServicioTransit>();
            services.AddScoped<ServicioScope>();
            services.AddSingleton<ServicioSingelton>();

            services.AddTransient<MiFilterAction>();

            //services.AddHostedService<WriteFileService>();
            
            services.AddResponseCaching();
            services.AddAuthentication(
                JwtBearerDefaults.AuthenticationScheme
            ).AddJwtBearer();
            services.AddSwaggerGen();
            services.AddAutoMapper(typeof(Startup));
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            app.UseLogResponse();
            app.Map("/ruta1", app =>
                app.Run(async context =>
                await context.Response.WriteAsync("parando la solicitudes"))
            );

            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseResponseCaching();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}