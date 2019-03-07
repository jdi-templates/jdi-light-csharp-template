using JDI.Light.Elements.Composite;
using JDI_Light_Template.Example.Entities;

using static JDI_Light_Template.Tests.SimpleTestsInit;

namespace JDI_Light_Template.Tests.Preconditions
{
    public class Preconditions
    {
        public static void ShouldBeLoggedIn()
        {
            if (!WebPage.PageUrl.Contains("https://epam.github.io/JDI/"))
                SiteJdi.HomePage.Open();
            if (!SiteJdi.UserName.Displayed)
                Login();
        }

        public static void Login()
        {
            SiteJdi.UserIcon.Click();
            SiteJdi.LoginForm.Submit(User.DefaultUser, "enter");
        }

        public static void ShouldBeLoggedOut()
        {
            if (!SiteJdi.HomePage.Url.Contains("https://epam.github.io/JDI/"))
                SiteJdi.HomePage.Open();
            if (SiteJdi.UserName.Displayed)
                Logout();
        }

        public static void Logout()
        {
            SiteJdi.UserIcon.Click();
            SiteJdi.Logout.Click();
        }
    }
}
