using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.SqlServer.Dts.Runtime;

using SSISHelper.Processor;


namespace SSISHelperTest.Processor
{
    [TestClass]
    public class Test
    {
        ProtectionLevelProcessor ProtectionLevelProcessor;
        Package Package;

        [TestInitialize]
        public void Initialize()
        {
            Package = new Package();
            ProtectionLevelProcessor = new ProtectionLevelProcessor();
        }

        [TestMethod]
        public void TestGetProtectionLevel()
        {
            Package.ProtectionLevel = DTSProtectionLevel.EncryptAllWithUserKey;
            DTSProtectionLevel Result = ProtectionLevelProcessor.GetProtectionLevel(Package);
            Assert.AreEqual(DTSProtectionLevel.EncryptAllWithUserKey, Result);
        }

        [TestMethod]
        public void TestSetProtectionLevel()
        {
            ProtectionLevelProcessor.SetProtectionLevel(Package, DTSProtectionLevel.ServerStorage);
            Assert.AreEqual(DTSProtectionLevel.ServerStorage, Package.ProtectionLevel);
        }
    }
}
