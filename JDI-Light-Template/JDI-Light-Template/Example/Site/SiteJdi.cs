using JDI.Light.Attributes;
using JDI.Light.Elements.Base;
using JDI.Light.Elements.Composite;
using JDI_Light_Template.Example.Site.Pages;
using JDI_Light_Template.Example.Site.Sections;
using OpenQA.Selenium;

namespace JDI_Light_Template.Example.Site
{
    [Site(Domain = "https://epam.github.io/JDI")]
    public class SiteJdi : WebSite
    {
        [Page(Url = "/dates.html", Title = "Dates Page")]
        public DatesPage DatesPage;

        [Page(Url = "/html5.html", Title = "Html5 Page")]
        public Html5Page Html5Page;

        [Page(Url = "/performance.html", Title = "Performance Page")]
        public JdiPerformancePage PerformancePage;

        [Page(Url = "/index.html", Title = "Home Page")]
        public HomePage HomePage;

        [Page(Url = "/contacts.html", Title = "Contact Form Page")]
        public ContactFormPage ContactFormPage;

        [Page(Url = "/contacts.html", Title = "Contacts Page")]
        public ContactsPage ContactsPage;

        [FindBy(Id = "login-form")]
        public LoginForm LoginForm;

        [FindBy(Css = ".profile-photo [ui=label]")]
        public UIElement UserName;

        [FindBy(Css = ".fa-sign-out")]
        public IWebElement Logout;

        [FindBy(Css = "img#user-icon")]
        public IWebElement UserIcon;

        [FindBy(Css = ".sidebar-menu")]
        public Menu LeftMenu;

        [FindBy(Css = ".uui-header")]
        public Header Header;

        //TODO Implement JList class. 
        //[FindBy(Css = ".sidebar-menu li")]
        //public static JList<MenuItem> Menu;
    }
}
