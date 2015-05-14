using System;

using Autofac;

using ImeiValidator.BusinessLayer;
using ImeiValidator.WebService;

namespace ImeiValidator.ConsoleApplication
{
    class Program
    {
        private static IContainer _container;

        static void Main(string[] args)
        {
            ImeiCommonRegistrations();

            Console.Write("Enter imei:");
            var imei = Console.ReadLine();

            var imeiProvider = _container.Resolve<IImeiProvider>();

            var result = imeiProvider.GetImeiStatus(imei);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        static void ImeiCommonRegistrations()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ConsoleDataRegistrations());
            builder.RegisterModule(new ImeiServiceRegistrations());
            _container = builder.Build();
        }
    }
}
