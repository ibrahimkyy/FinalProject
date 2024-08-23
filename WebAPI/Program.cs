
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFremwork;
using Microsoft.Identity.Client;

namespace WebAPI
{
    public class Program
    {
        /*public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddControllers();
            services.AddSingleton<IProductServis,ProductManager>();//IProductService görürsen karþýlýðý ProductManagerdýr arka planda bizim yerimize newliyo
            services.AddSingleton<IProductDal, EfProductDal>();
        }*/
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddSingleton<IProductServis, ProductManager>();
            builder.Services.AddSingleton<IProductDal, EfProductDal>();

           
            
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
    }
}
