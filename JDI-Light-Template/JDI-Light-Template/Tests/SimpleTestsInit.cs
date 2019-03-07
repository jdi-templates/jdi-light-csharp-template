using JDI.Light;
using JDI.Light.Enums;
using JDI.Light.Utils;
using JDI_Light_Template.Example.Site;
using JDI_Light_Template.Tests.Asserts;
using NUnit.Framework;

namespace JDI_Light_Template.Tests
{
    public class SimpleTestsInit
    {
        public static SiteJdi SiteJdi { get; set; }

        [SetUp]
        public void SetUp()
        {
            Jdi.Init(assert: new NUnitAsserter());
            Jdi.Logger.LogLevel = LogLevel.Debug;
            Jdi.DriverFactory.GetLatestDriver = false;
            Jdi.DriverFactory.DriverVersion = "2.41";
            Jdi.Logger.Info("Init test run...");
            Jdi.Timeouts.WaitElementMSec = 10000;
            Jdi.Timeouts.WaitPageLoadMSec = 10000;
            new WinProcUtils().KillAllRunningDrivers();
            SiteJdi = Jdi.InitSite<SiteJdi>();
            SiteJdi.HomePage.Open();
            Jdi.Logger.Info("Run Tests");
        }

        [TearDown]
        public void TearDown()
        {
            new WinProcUtils().KillAllRunningDrivers();
        }
    }
}