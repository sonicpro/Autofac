using System;
using Autofac;
using DemoApp.PublicInterfaces;

namespace DemoApp
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayWriter>().As<IDateWriter>();
            Container = builder.Build();

            // The WriteDate method is where we'll make use of our dependency injection.
            // We'll define that in a bit.
            WriteDate();
        }

        public static void WriteDate()
        {
            // Create the child lifetime scope, resolve your IDateWriter dependency,
            // use it, then dispose of the scope.
            using (var scope = Container.BeginLifetimeScope())
            {
                // I guess the IOutput dependency is resolved from the container itself.
                var writer = scope.Resolve<IDateWriter>();
                writer.WriteDate();
            }
        }
    }
}
