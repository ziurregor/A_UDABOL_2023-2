using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace backend
{
    public class Program
    {
        // public static void Main(string[] args)
        // {
        //     Activity.DefaultIdFormat = ActivityIdFormat.W3C;
        //     CreateHostBuilder(args).Build().Run();
        // }
        // public static IHostBuilder CreateHostBuilder(string[] args) =>
        //     Host.CreateDefaultBuilder(args)
        //     .ConfigureWebHostDefaults(webBuilder =>
        //     {
        //         webBuilder.UseStartup<Startup>();
        //         webBuilder.ConfigureKestrel((context, options) =>
        //         {
        //             options.ListenAnyIP(8080); // Escuchar en todas las interfaces de red (0.0.0.0) en el puerto 8080
        //         });
        //     });
        //.ConfigureWebHostDefaults(webBuilder =>
        //{
        //    //webBuilder.UseStartup<Startup>();
        //    webBuilder.UseStartup<Startup>();
        //    webBuilder.UseKestrel(options =>
        //    {
        //        options.Listen(System.Net.IPAddress.Loopback, 8080); // Especifica la dirección IP y el puerto aquí
        //    });
        //});
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
