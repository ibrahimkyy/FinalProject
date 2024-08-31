
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using Core.Utilities.Security.Encryption;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFremwork;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;

namespace WebAPI
{
    /* public class Program
     {
         /*public void ConfigureServices(IServiceCollection services)
         {

             services.AddControllers();
             services.AddSingleton<IProductServis,ProductManager>();//IProductService görürsen karþýlýðý ProductManagerdýr arka planda bizim yerimize newliyo
             services.AddSingleton<IProductDal, EfProductDal>();
         }
         public static void Main(string[] args)
         {
             var builder = WebApplication.CreateBuilder(args);

             // Add services to the container.
             builder.Services.AddControllers();
             //builder.Services.AddSingleton<IProductServis, ProductManager>();
             //builder.Services.AddSingleton<IProductDal, EfProductDal>();



             // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
             builder.Services.AddEndpointsApiExplorer();
             builder.Services.AddSwaggerGen();

             var app = builder.Build();

             // Configure the HTTP request pipeline.
             if (app.Environment.IsDevelopment())
             {
                 app.UseSwagger();
                 app.UseSwaggerUI();
             }

             app.UseHttpsRedirection();

             app.UseAuthorization();


             app.MapControllers();

             app.Run();


         }

         public static IHostBuilder CreateHostBuilder(string[] args) =>
                     Host.CreateDefaultBuilder(args)
                         .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                         .ConfigureContainer<ContainerBuilder>(builder =>
                         {
                             builder.RegisterModule(new AutofacBusinessModule());
                         });



     }
    
    public class Program
    {
        public Program(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin",
                    builder => builder.WithOrigins("http://localhost:3000"));
            });

            var tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = tokenOptions.Issuer,
                        ValidAudience = tokenOptions.Audience,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
                    };
                });
            static void Main(string[] args)
            {
                var builder = WebApplication.CreateBuilder(args);

                // Autofac kullanýmý için özel bir ServiceProviderFactory ekleyin.
                builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

                // Autofac modüllerini veya servislerini burada kaydedin.
                builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
                {
                    containerBuilder.RegisterModule(new AutofacBusinessModule());
                });

                // Servisleri ekleyin.
                builder.Services.AddControllers();
                //builder.Services.AddSingleton<IProductService, ProductManager>();
                // builder.Services.AddSingleton<IProductDal, EfProductDal>();

                // Swagger/OpenAPI desteði
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen();

                var app = builder.Build();

                // HTTP request pipeline'ý yapýlandýrýn.
                if (app.Environment.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                app.UseHttpsRedirection();
                app.UseAuthorization();
                app.MapControllers();

                app.Run();
            }

        }
        public class Startup
        {
            public IConfiguration Configuration { get; }
            public Startup(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            public void ConfigureServices(IServiceCollection services)
            {
                services.AddSingleton<ITokenHelper, JwtHelper>();
            }
        }
    }*/

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureContainer<ContainerBuilder>(builder =>
                {
                    builder.RegisterModule(new AutofacBusinessModule());
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
