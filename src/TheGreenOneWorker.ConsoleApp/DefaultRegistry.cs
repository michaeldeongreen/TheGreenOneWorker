using StructureMap;

namespace TheGreenOneWorker.ConsoleApp
{
    public class DefaultRegistry : Registry
    {
        public DefaultRegistry()
        {
            Scan(scan => {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });
        }
    }
}
