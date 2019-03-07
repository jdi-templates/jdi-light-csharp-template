using JDI.Light.Attributes;
using JDI.Light.Elements.Common;
using JDI.Light.Elements.Composite;
using JDI_Light_Template.Example.Entities;

namespace JDI_Light_Template.Example.Site.Sections
{
    public class ContactForm : Form<Contacts>
    {
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

        public void FillAction(TextField field, object element, object parent, string setValue)
        {
            /*if(IsInterface(field, typeof(TextField)))
            {
                ((TextField)element).Highlight();
            }
            base.FillAction(field, element, parent, setValue);*/
        }
    }
}
