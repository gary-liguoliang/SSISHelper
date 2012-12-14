using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Dts.Runtime;

namespace SSISHelper.com.liguoliang.ssis.util
{
    class DtsUtils
    {
        /**
         * Change DTSX package password
         */
        public static void ChangePassword(String pkgLocation, String oldPassword, DTSProtectionLevel dtsPrdLevel, String newPassword)
        {
            Application app = new Application();

            if (oldPassword != null && oldPassword.Trim() != "")
            {
                app.PackagePassword = oldPassword;
            }

            Package pkg = app.LoadPackage(pkgLocation, null);

            // Modify the password
            pkg.ProtectionLevel = dtsPrdLevel;
            pkg.PackagePassword = newPassword;

            // Save dts pacakge
            app.SaveToXml(pkgLocation, pkg, null);
        }

        public static void UpdateAllPkgPassword(String pathRoot, String oldPassword, DTSProtectionLevel dtsPrdLevel, String newPassword)
        {
            String[] DtsFiles = FileUtils.GetAllDtsPkgs(pathRoot);
            foreach (String DtsPkg in DtsFiles)
            {
                ChangePassword(DtsPkg, oldPassword, dtsPrdLevel, newPassword);
            }
        }
    }
}
