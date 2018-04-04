using StructureMap.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGreenOneWorker.Services.Interfaces;

namespace TheGreenOneWorker.Services
{
    public class PreApprovalProcessor : BaseProcessor<PreApprovalProcessor>
    {
        [SetterProperty]
        public AppQRepository AppQRepository { get; set; }
        [SetterProperty]
        public IMCERepository MCERepository { get; set; }
        protected override void Process()
        {
            var a = AppQRepository.Get(1);
            var m = MCERepository.Get(2);
            string name = "PreApproval";
        }

        public override string GetProcessorType()
        {
            return "PreApprovalProcessor";
        }
    }
}
