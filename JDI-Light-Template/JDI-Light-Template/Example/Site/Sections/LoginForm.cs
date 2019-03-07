using JDI.Light.Attributes;
using JDI.Light.Elements.Composite;
using JDI.Light.Interfaces.Common;
using JDI_Light_Template.Example.Entities;

namespace JDI_Light_Template.Example.Site.Sections
{
    public class LoginForm : Form<User>
    {
        [FindBy(Css = "button.btn-login")]
        [Name("Login")]
        public IButton LoginButton;

        [FindBy(Css = "#name")]
        [Name("Login")]
        public ITextField LoginField;

        [FindBy(Css = "#password")]
        [Name("Password")]
        public ITextField PasswordField;
    }
}
