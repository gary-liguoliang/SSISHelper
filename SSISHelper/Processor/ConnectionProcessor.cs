using Microsoft.SqlServer.Dts.Runtime;

namespace SSISHelper.Processor
{
    public class ConnectionProcessor
    {
        public Connections GetDTSConnections(Package package)
        {
            return package.Connections;
        }
    }
}
