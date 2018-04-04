using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGreenOneWorker.Services;

namespace TheGreenOneWorker.ConsoleApp
{
    public static class IoC
    {
        public static IContainer Initialize()
        {
            var registry = new Registry();
            registry.IncludeRegistry<ServiceRegistry>();
            registry.IncludeRegistry<DefaultRegistry>();
            var container = new Container(registry);
            return container;
        }
    }
}
