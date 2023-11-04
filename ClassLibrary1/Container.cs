using ClassLibrary2;
using StrongInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Register(typeof(Test1Impl), typeof(ITest1))]
    public static class Module1 { }
}
