using System;
using Dal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ormHelper orm = new ormHelper();
            HR_SMSInfo model = orm.Get<HR_SMSInfo>("f6c5b6dd-ba9c-4fc5-a07c-081ab1522d40");
        }
    }
}
