using StructureMap.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGreenOneWorker.Services.Interfaces;

namespace TheGreenOneWorker.Services
{
    public class PreDecisionDataProcessor : BaseProcessor<PreDecisionDataProcessor>
    {
        [SetterProperty]
        public IMCERepository MCERepository { get; set; }

        public override string GetProcessorType()
        {
            return "PreDecisionDataProcessor";
        }

        protected override void Process()
        {
            string name = "PreDecisionData";
        }
    }
}
