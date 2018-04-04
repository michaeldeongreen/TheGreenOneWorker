using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGreenOneWorker.Domain;
using TheGreenOneWorker.Services;

namespace TheGreenOneWorker.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer container = IoC.Initialize();
            BaseProcessor.Container = container;

            Worker.Process();
            Console.ReadLine();
        }
    }
}
