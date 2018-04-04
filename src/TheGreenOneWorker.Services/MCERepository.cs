using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGreenOneWorker.Domain;
using TheGreenOneWorker.Services.Interfaces;

namespace TheGreenOneWorker.Services
{
    public class MCERepository : IMCERepository
    {
        public MCEObject Get(int Id)
        {
            return new MCEObject() { Id = Id };
        }
    }
}
