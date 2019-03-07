using JDI.Light.Elements.Base;
using OpenQA.Selenium;

namespace JDI_Light_Template.Example.Site.Custom
{
    public class MenuItem : UIElement
    {
        public MenuItem(By byLocator = null)
            : base(byLocator)
        {
        }

        public bool IsSelected()
        {
            return //HasClass("active") &&
                 GetAttribute("ui").Equals("label");
        }
    }
}
