using NUnit.Framework;
using SmsTools.Interfaces;
using System;

namespace SmsTools.NUnitTests
{
    public class Tests
    {
        [OneTimeSetUp]
        public void FirstTimeSetup()
        {
            LocalSettings.Setup();
        }

        [Test]
        public void Test1()
        { 
            Assert.IsTrue(Environment.GetEnvironmentVariable("MyName") =="Zeke");
        }
    }
}