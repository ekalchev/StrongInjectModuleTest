using ClassLibrary1;
using ClassLibrary2;
using StrongInject;
using System.Reflection;

namespace StrongInjectTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var container = new Container())
            {
                using (var application = container.Resolve<Application>())
                {
                    application.Value.Run();
                }
            }
        }
    }

    [Register(typeof(Application))]
    [RegisterModule(typeof(Module1))]
    public partial class Container : IContainer<Application> { }
}