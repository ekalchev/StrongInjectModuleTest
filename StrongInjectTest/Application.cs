using ClassLibrary1;
using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongInjectTest
{
    public class Application
    {
        private readonly Func<ITest1> testFactory;

        public Application(Func<ITest1> testFactory)
        {
            this.testFactory = testFactory;
        }

        public void Run()
        {
            var instance = testFactory();
            // instance should be of type Test1Impl
            Debugger.Break();
        }
    }
}
