using JDI.Light.Elements.Composite;
using JDI_Light_Template.Example.Entities;
using JDI_Light_Template.Example.Site.Pages;
using JDI_Light_Template.Example.Site.Sections;
using NUnit.Framework;
using OpenQA.Selenium;

using static JDI_Light_Template.Example.Entities.Contacts;
using static JDI_Light_Template.Example.Entities.User;
using static JDI_Light_Template.Tests.Preconditions.Preconditions;

namespace JDI_Light_Template.Tests.Example
{
    [TestFixture]
    public class FormTests : SimpleTestsInit
    {
        private static ContactForm ContactForm => SiteJdi.ContactFormPage.contactForm;
        private static ContactFormPage ContactFormPage => SiteJdi.ContactFormPage;
        private static ContactsPage ContactsPage => SiteJdi.ContactsPage;
        private static Menu Menu => SiteJdi.Header.Menu;
        private static LoginForm LoginForm => SiteJdi.LoginForm;
        private static HomePage HomePage => SiteJdi.HomePage;
        private static IWebElement UserIcon => SiteJdi.UserIcon;


        [Test]
        public void LoginTest()
        {
            ShouldBeLoggedOut();
            UserIcon.Click();
            LoginForm.Submit(DefaultUser, "Login");
            HomePage.CheckOpened();
        }

        [Test]
        public void FillContactFormTest()
        {
            ShouldBeLoggedIn();
            Menu.MenuItemLocator = By.XPath(".//li/a");
            Menu.Select("CONTACT FORM");
            ContactFormPage.CheckOpened();
            ContactForm.Submit(DefaultContact);
            ContactForm.Check(DefaultContact);
        }

        [Test]
        public void FillContactsTest()
        {
            ShouldBeLoggedIn();
            Menu.MenuItemLocator = By.XPath(".//li/a");
            Menu.Select("CONTACT FORM");
            ContactsPage.CheckOpened();
            ContactsPage.AsForm<Contacts>().Submit(DefaultContact);
            ContactsPage.AsForm<Contacts>().Check(DefaultContact);
        }
    }
}
