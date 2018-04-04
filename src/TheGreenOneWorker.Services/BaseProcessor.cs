using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreenOneWorker.Services
{
    public abstract class BaseProcessor<TProcessorType> : BaseProcessor where TProcessorType : BaseProcessor, new()
    {
        public new static void Start()
        {
            Type t = typeof(TProcessorType);

            var processor = Container.GetAllInstances<BaseProcessor>().SingleOrDefault(p => p.GetProcessorType() == t.Name );

            processor.Start();
        }

        public static void Run()
        {
            Start();
        }
    }
    public abstract class BaseProcessor
    {
        public static IContainer Container;
        
        protected abstract void Process();

        public abstract string GetProcessorType();

        internal void Start()
        {
            Process();
        }
    }
}
