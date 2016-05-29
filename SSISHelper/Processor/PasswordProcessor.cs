using Microsoft.SqlServer.Dts.Runtime;
using System;

namespace SSISHelper.Processor
{
    public class PasswordProcessor
    {
        public void ChangePassword(Package package, String newPassword)
        {
            package.ProtectionLevel = DTSProtectionLevel.EncryptAllWithPassword;
            package.PackagePassword = newPassword;
        }
    }
}
