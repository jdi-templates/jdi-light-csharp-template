using JDI.Light.Attributes;
using JDI.Light.Elements.Common;
using JDI.Light.Elements.Composite;
using JDI_Light_Template.Example.Site.Sections;

namespace JDI_Light_Template.Example.Site.Pages
{
    [Page(Url = "/contacts.html", Title = "Contact Form")]
    public class ContactsPage : WebPage
    {
        public ContactForm contactForm;

        [Name("Name")]
        [FindBy(Css = "#contact-form input[id='name']")]
        public TextField name;

        [Name("LastName")]
        [FindBy(Css = "#last-name")]
        public TextField lastName;

        [Name("Position")]
        [FindBy(Css = "#position")]
        public TextField position;

        [Name("PassportNumber")]
        [FindBy(Css = "#passport-number")]
        public TextField passportNumber;

        [Name("PassportSeria")]
        [FindBy(Css = "#passport-seria")]
        public TextField passportSeria;

        //Dropdown gender;
        //Combobox religion;

        [FindBy(Css = "#passport")]
        public CheckBox passport;

        [Name("AcceptConditions")]
        [FindBy(Css = "#accept-conditions")]
        public CheckBox acceptConditions;

        [Name("Description")]
        [FindBy(Css = "#description")]
        public TextArea description;

        [FindBy(XPath = "//*[text()='Submit']")]
        public Button submit;
    }
}
