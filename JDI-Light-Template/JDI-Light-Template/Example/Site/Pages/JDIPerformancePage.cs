using JDI.Light.Attributes;
using JDI.Light.Elements.Common;
using JDI.Light.Elements.Composite;

namespace JDI_Light_Template.Example.Site.Pages
{
    [Page(Url = "/performance.html")]
    public class JdiPerformancePage : WebPage
    {
        [FindBy(Css = "#users-table")]
        public Table UsersTable;

        //[FindBy(Css = "#user-names")]
        //public Dropdown UserNames;

        [FindBy(Css = "#textarea-performance")]
        public TextArea TextareaPerformance;
    }
}
