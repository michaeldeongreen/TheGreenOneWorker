using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGreenOneWorker.Domain;
using TheGreenOneWorker.Services.Interfaces;

namespace TheGreenOneWorker.Services
{
    public class AppQRepository : IAppQRepository
    {
        public AppQObject Get(int Id)
        {
            return new AppQObject() { Id = Id };
        }
    }
}
