using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using FolderLister.PublicInterfaces;

namespace FolderLister
{
    class Program
    {
        static IContainer _container;

        static void Main(string[] args)
        {
            Register();

            IProcessor processor = _container.Resolve<IProcessor>();

            Console.WriteLine("Content of path:");
            processor.ShowContents().ToList().ForEach(
                n => Console.WriteLine(n)
            );
            Console.ReadLine();
        }

        // Setup the configuration for Autofac container.
        private static void Register()
        {
            ContainerBuilder builder = new ContainerBuilder();

            // Chose either one Service Type for IParameters or another.
            // builder.RegisterType<ParametersLocal>().As<IParameters>().SingleInstance();

            builder.RegisterType<ParametersCustom>().As<IParameters>()
                .WithParameter(new TypedParameter(typeof(string), "C:\\"))
                .SingleInstance();

            // Resolve() call will call the Processor constructor, althogh the project compile well even if no constructor at all!
            //builder.RegisterType<Processor>().As<IProcessor>();

            // Register() instead RegisterType<>() - can be considered as safer alternative (constructor presence is checked at compile time).
            // We will pass the lambda to Register() that takes IComponentContext and returns the service type instance.
            builder.Register(c => new Processor(_container.Resolve<IParameters>()))
                .As<IProcessor>();
            
            _container = builder.Build();
        }
    }
}
