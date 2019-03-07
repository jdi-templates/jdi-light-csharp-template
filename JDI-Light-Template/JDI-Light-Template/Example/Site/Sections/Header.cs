using JDI.Light.Attributes;
using JDI.Light.Elements.Composite;
using JDI.Light.Interfaces.Common;

namespace JDI_Light_Template.Example.Site.Sections
{
    public class Header : Section
    {
        [FindBy(XPath = "//img[@src=\"label/Logo_Epam_Color.svg\"]")]
        public IImage Image;

        [FindBy(Css = "ul.uui-navigation.nav")]
        public Menu Menu;
    }
}
