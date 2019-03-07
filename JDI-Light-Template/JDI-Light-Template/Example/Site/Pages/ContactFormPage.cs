using JDI.Light.Attributes;
using JDI.Light.Elements.Composite;
using JDI_Light_Template.Example.Site.Sections;

namespace JDI_Light_Template.Example.Site.Pages
{
    [Page(Url = "/contacts.html", Title = "Contact Form Page")]
    public class ContactFormPage : WebPage
    {
        [FindBy(Css = "form#contact-form")]
        public ContactForm contactForm;
    }
}
