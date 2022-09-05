
using System.Text;
using apiTienda.Filtros;
using apiTienda.IServicios;
using apiTienda.Middelwares;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

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
            //services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
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
            ).AddJwtBearer(
                options =>
                {
                    options.TokenValidationParameters =
                        new TokenValidationParameters
                        {
                            ValidateIssuer = false,
                            ValidateAudience = false,
                            ValidateLifetime = true,
                            ValidateIssuerSigningKey = true,
                            IssuerSigningKey = new SymmetricSecurityKey(
                                Encoding.UTF8.GetBytes(Configuration["jwt"])
                            ),
                            ClockSkew = TimeSpan.Zero
                        };
                }
            );
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "web api tienda", Version = "v1" });
                c.AddSecurityDefinition(
                  "Bearer",
                   new OpenApiSecurityScheme
                   {
                       Name = "autorization",
                       Scheme = "Bearer",
                       Type = SecuritySchemeType.ApiKey,
                       BearerFormat = "JWT",
                       In = ParameterLocation.Header
                   });
                c.AddSecurityRequirement(
                  new OpenApiSecurityRequirement
                  {
                    {
                        new OpenApiSecurityScheme{
                            Reference= new OpenApiReference{
                                Type=ReferenceType.SecurityScheme,
                                Id="Bearer"
                            }
                        },
                        new string[]{
                            
                        }
                    }
                  }
                );
            });
            services.AddAutoMapper(typeof(Startup));
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AplicationDbContext>().AddDefaultTokenProviders();
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
                app.UseSwagger(
                );

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