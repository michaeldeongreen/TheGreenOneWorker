using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGreenOneWorker.Domain;

namespace TheGreenOneWorker.Services.Interfaces
{
    public interface IAppQRepository
    {
        AppQObject Get(int Id);
    }
}
