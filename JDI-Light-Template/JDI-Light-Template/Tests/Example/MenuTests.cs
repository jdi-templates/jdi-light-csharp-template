using JDI.Light.Elements.Composite;
using JDI_Light_Template.Example.Site.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

using static JDI_Light_Template.Example.Entities.LeftMenuData;
using static JDI_Light_Template.Tests.Preconditions.Preconditions;

namespace JDI_Light_Template.Tests.Example
{
    public class MenuTests : SimpleTestsInit
    {
        private static HomePage HomePage => SiteJdi.HomePage;
        private static Menu LeftMenu => SiteJdi.LeftMenu;
        private static DatesPage DatesPage => SiteJdi.DatesPage;
        private static Html5Page Html5Page => SiteJdi.Html5Page;

        [SetUp]
        public void SetUpMenu()
        {
            ShouldBeLoggedIn();
            HomePage.CheckOpened();
            LeftMenu.MenuItemLocator = By.XPath(".//li/a");
        }

        [Test]
        public void MenuTest()
        {
            LeftMenu.Select(Service, Dates);
            DatesPage.CheckOpened();
            LeftMenu.Select(ElementsPacks, HTML5);
            Html5Page.CheckOpened();
        }

        [Test]
        public void CustomMenuTest()
        {
            //SiteJdi.Menu.Select(ContactForm);
            //Assert.AreEqual(ContactForm, SiteJdi.Menu.IsSelected());
            //SiteJdi.Menu.Select(Service, Dates);
            //SiteJdi.Menu.Is().Selected(Dates);
            DatesPage.CheckOpened();
            LeftMenu.Select(ElementsPacks, HTML5);
            Html5Page.CheckOpened();
        }
    }
}
