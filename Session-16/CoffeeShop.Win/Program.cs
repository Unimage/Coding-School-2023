using CoffeeShop.Model;
using CoffeeShop.Orm.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace Session_11 {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();

            services.AddSingleton<IEntityRepo<ProductCategory>, ProductCategoryRepo>();
            services.AddSingleton<Form1>();
            ServiceProvider = services.BuildServiceProvider();
            var mainForm = ServiceProvider.GetRequiredService<Form1>();
            Application.Run(new CoffeeShopF());
        
            /// this is a commeent
        }
    }
}