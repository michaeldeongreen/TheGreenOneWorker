using TheGreenOneWorker.Domain;

namespace TheGreenOneWorker.Services
{
    public class Worker : BaseWorker
    {
        public static bool Process()
        {
            BaseProcessor<PreApprovalProcessor>.Run();
            BaseProcessor<PreDecisionDataProcessor>.Run();
            return true;
        }
        public override bool DoWork()
        {
            return true;
        }
    }
}
