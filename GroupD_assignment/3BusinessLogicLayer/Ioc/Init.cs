using _3BusinessLogicLayer.Interfaces;
using _3BusinessLogicLayer.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace _3BusinessLogicLayer.Ioc
{
    public static class Init
    {
        public static void InitializeDependencies(IServiceCollection services, IConfiguration configuration)
        {

            // Services
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IStaffService, StaffService>();
<<<<<<< HEAD
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IProductService, ProductService>();
=======
            services.AddScoped<IStockService, StockService>();
            services.AddScoped<IProductLossService, ProductLossService>();
>>>>>>> f1def32854d0f4774c418cb1f2eb0f17d2181dd8
            //services.AddScoped<ICategoryService, CategoryService>();

        }
    }
}
