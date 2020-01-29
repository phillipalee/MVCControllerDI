using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Moq;
using MVCControllerDI.Controllers;

namespace MVCControllerDI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create the mock data source
            var mockRecRepo = new Mock<IRecordRepo>();

            // set up the behavior that you want (you could have it return a value(s)
            mockRecRepo.Setup(x => x.GetRecords())
                .Returns(Enumerable.Empty<Record>);

            // Here's a demo of passing the controller the repository in the constructor
            var controller = new ThingsController(mockRecRepo.Object);

            // put the View object in a var 
            var result = controller.Index();

            //  break at the next satement and check out what's in result. Then just let it run
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
