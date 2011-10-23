using System;
using System.ServiceModel;
using Castle.Facilities.WcfIntegration;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Contract;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Kernel.AddFacility<WcfFacility>();
            container.Register(Component.For<IService>()
                                .AsWcfClient(new DefaultClientModel()
                                {
                                    Endpoint = WcfEndpoint.BoundTo(new BasicHttpBinding()).At("http://localhost:23002/MessageService.svc")
                                }));

            var service = container.Resolve<IService>();


            var name = Console.ReadLine();
            var response = service.GetMessage(new GetMessageRequest() { Name = name });

            Console.WriteLine(response.Message);
        }
    }
}
