using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetShelter.Shared.Extensions;
using static System.Collections.Immutable.ImmutableArray<T>;

namespace PetShelterMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            builder.Services.AddControllersWithViews();
            Builder.Services.AddDbContext<PetShelterDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]);
            });
            var app = builder.Build();

            using(var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<PetShelterDbContext>();
                context.Database.Migrate();
            }

            builder.Services.AddAutoMapper(m => m.AddProfile(new AutoMapperConfiguration()));

            builder.Services.AutoBind(typeof(PetsService).Assembly);
            builder.Services.AutoBind(typeof(PetsRepository).Assembly);

            //builder.Services.AddAutoMapper(m => m.AddProfile(new AutoMapperConfiguration()));
            //IJwtSettings settings = builder.Configuration.GetSection(typeof(JwtSettings).Name).Get<JwtSettings>();

            //IJwtSettings settings = builder.Configuration.GetSection(typeof(JwtSettings).Name).Get<JwtSettings>();

            //builder.Services.AddAuthentication(cfg => cfg.DefaultScheme = JwtBearerDefaults.AuthenticationScheme)
            //                //.AddJwtBearer(options =>
            //                {
            //                    if (options.SecurityTokenValidators.FirstOrDefault() is JwtSecurityTokenHandler jwtSecurityTokenHandler)
            //                    {
            //                        jwtSecurityTokenHandler.MapInboundClaims = false;
            //                    }
            //                    options.RequireHttpsMetadata = false;
            //                    options.SaveToken = true;
            //                    options.TokenValidationParameters = new TokenValidationParameters
            //                    {
            //                        ValidateIssuer = true,
            //                        ValidateAudience = true,
            //                        ValidateLifetime = true,
            //                        ValidateIssuerSigningKey = true,
            //                        ValidIssuer = settings.Issuer,
            //                        ValidAudience = settings.Audience,
            //                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(settings.Key)),
            //                        NameClaimType = JwtRegisteredClaimNames.Sub
            //                    };
            //                    options.Events = new JwtBearerEvents
            //                    {
            //                        OnMessageReceived = context =>
            //                        {
            //                            var accessToken = context.Request.Query["access_token"];

            //                // If the request is for our hub...
            //                var path = context.HttpContext.Request.Path;
            //                            if (!string.IsNullOrEmpty(accessToken) &&
            //                                (path.StartsWithSegments("/chathub")))
            //                            {
            //                    // Read the token out of the query string
            //                    context.Token = accessToken;
            //                            }
            //                            return Task.CompletedTask;
            //                        }
            //                    };
            //                });

            //builder.Services.AddSingleton(settings);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
