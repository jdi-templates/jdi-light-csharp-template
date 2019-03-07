using JDI.Light.Attributes;

namespace JDI_Light_Template.Example.Entities
{
    public class Contacts
    {
        public static readonly Contacts DefaultContact = new Contacts("Roman",
            "Iovlev",
            "ChiefQA",
            "4321",
            "123456",
            "JDI - awesome UI automation tool",
            "true",
            "Female",
            "Other");

        public Contacts(string name, string lastName, string position, string passportNumber, string passportSeria, string description, string acceptConditions, string gender, string religion)
        {
            Name = name;
            LastName = lastName;
            Position = position;
            PassportNumber = passportNumber;
            PassportSeria = passportSeria;
            Description = description;
            AcceptConditions = acceptConditions;
            Gender = gender;
            Religion = religion;
        }

        [Name("Name")]
        public string Name { get; set; }

        [Name("LastName")]
        public string LastName { get; set; }

        [Name("Position")]
        public string Position { get; set; }

        [Name("PassportNumber")]
        public string PassportNumber { get; set; }

        [Name("PassportSeria")]
        public string PassportSeria { get; set; }

        [Name("Description")]
        public string Description { get; set; }

        [Name("AcceptConditions")]
        public string AcceptConditions { get; set; }

        [Name("Gender")]
        public string Gender { get; set; }

        [Name("Religion")]
        public string Religion { get; set; }
    }
}
