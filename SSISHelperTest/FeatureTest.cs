using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.SqlServer.Dts.Runtime;
using SSISHelper.Processor;
using SSISHelper.Util;
using System.Diagnostics;

namespace SSISHelperTest
{
    /// <summary>
    /// Summary description for FeatureTest
    /// </summary>
    [TestClass]
    public class FeatureTest
    {
        
        public FeatureTest()
        {
           
        }

        [TestMethod]
        public void TestBasicFeature()
        {
            var application = new Application();
            var protectionLevelProcessor = new ProtectionLevelProcessor();
            foreach (var dtsFile in FileUtils.GetDTSFileList("d:\\dev\\projects\\ssis-dev"))
            {
                Package package = application.LoadPackage(dtsFile, null);
                Trace.WriteLine(protectionLevelProcessor.GetProtectionLevel(package));
            }
        }
    }
}
