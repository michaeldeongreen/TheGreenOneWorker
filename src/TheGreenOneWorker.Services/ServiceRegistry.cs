using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreenOneWorker.Services
{
    public class ServiceRegistry : Registry
    {
        public ServiceRegistry()
        {
            Scan(scan => {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
                scan.AddAllTypesOf<BaseProcessor>();
            });
        }
    }
}
