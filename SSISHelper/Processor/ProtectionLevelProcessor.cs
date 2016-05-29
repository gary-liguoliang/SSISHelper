using Microsoft.SqlServer.Dts.Runtime;

namespace SSISHelper.Processor
{
    public class ProtectionLevelProcessor
    {
        public DTSProtectionLevel GetProtectionLevel(Package package)
        {
            return package.ProtectionLevel;
        }

        public void SetProtectionLevel(Package package, DTSProtectionLevel protectionLevel)
        {
            package.ProtectionLevel = protectionLevel;
        }
    }
}
