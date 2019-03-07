using System;
using System.Diagnostics;
using JDI_Light_Template.Example.Site.Pages;
using NUnit.Framework;

using static JDI_Light_Template.Example.TestData;
using static JDI_Light_Template.Tests.Preconditions.Preconditions;

namespace JDI_Light_Template.Tests.Example
{
    public class JdiPerformanceTests : SimpleTestsInit
    {
        private static JdiPerformancePage PerformancePage => SiteJdi.PerformancePage;

        [SetUp]
        public void OpenPerformancePage()
        {
            ShouldBeLoggedIn();
            PerformancePage.Open();
            PerformancePage.CheckOpened();
        }

        [Test]
        public void HugeTableSearchTest()
        {
            //TODO implement functionality for finding particular row in a table that contains several cells with some values in particular columns.
            /*PerformancePage.UsersTable.assertThat().hasRowWithValues(
                containsValue("Meyer", inColumn("Name")),
                containsValue("co.uk", inColumn("Email")));*/
            Stopwatch timer = Stopwatch.StartNew();
            /*Line row = PerformancePage.UsersTable.row(
                containsValue("Meyer", inColumn("Name")),
                containsValue("co.uk", inColumn("Email")));*/
            Console.WriteLine("Huge table search test Time: " + timer.ElapsedMilliseconds);
            //TODO implement GetValue() method for table row.
            /*Assert.AreEqual("Brian Meyer;(016977) 0358;mollis.nec@seddictumeleifend.co.uk;Houston",
             row.getValue());*/
        }

        [Test]
        public void HugeTableValidateTest()
        {
            Stopwatch timer = Stopwatch.StartNew();
            //TODO Implement Preview() method for getting text of Table.
            //string actualTable = PerformancePage.UsersTable.Preview();
            Console.WriteLine("Huge table search test Time: " + timer.ElapsedMilliseconds);
            //Assert.AreEqual(TABLE_SNAPSHOOT, actualTable);
        }

        [Test]
        public void BigDropdownTest()
        {
            string name = "Charles Byers";
            Stopwatch timer = Stopwatch.StartNew();
            //TODO Implement Dropdown control with Select(string name) method.
            //PerformancePage.UserNames.Select(name);
            Console.WriteLine("Big dropdown test Time: " + timer.ElapsedMilliseconds);
            //Assert.AreEqual(name, PerformancePage.UserNames.Selected());
        }

        [Test]
        public void LongTextTest()
        {
            string text = "Lorem ipsum dolor sit amet, eos numquam rationibus ad. Ius cu accumsan salutatus, ne pro purto ridens vulputate. Cu eum doctus tritani, munere sanctus complectitur vis id. Paulo vulputate te eos, suas tollit laudem nam id. His esse rebum reprimique ut, te solum atqui homero vim.\\n\\n" +
                          "Labitur salutatus eos an. Vim ut dicam fuisset. Ex sed animal accommodare, utinam graeci iisque vim id, ea fugit scripta deleniti nec. Eos cu nisl veri meis. Affert audiam copiosae mel ne, fabulas menandri temporibus has et. Sed latine graecis ei, eu fugit soluta intellegam vis, nibh graeci meliore ad duo.\\n\\n" +
                          "Et quis meis delenit mea, ius ea sumo laboramus vituperatoribus. Te simul luptatum tractatos nam, eam in causae constituam, quod stet ancillae nam ei. Ne his dico veniam legere, id has vidisse euismod sanctus. Vis putant volumus tincidunt et.\\n\\n" +
                          "Has eirmod consequat ad. Sea illud clita ut, has quando accusata cotidieque an, volutpat iudicabit definitionem ut sea. Pri at atqui molestiae, nibh ullum consulatu vix at. Nec id nisl nonumes epicurei, et vitae possit probatus ius. Fierent delicata argumentum ut quo. Tation tincidunt sed eu, sit in nostrud democritum.\\n\\n" +
                          "Usu esse utroque sapientem ad. Eam ut consul soleat sapientem, cu dolor consequuntur vis. Erat temporibus mea id, has ex dicam tritani. Pertinacia expetendis consectetuer eos ei, vidit malis periculis est ea, ne nam movet fuisset. Pro id habemus definitiones, in ferri solum reprehendunt mei. Vel eligendi honestatis liberavisse id.";
            Stopwatch timer = Stopwatch.StartNew();
            PerformancePage.TextareaPerformance.SendKeys(text + "\\n" + text);
            Console.WriteLine("Long text test Time: " + timer.ElapsedMilliseconds);
        }
    }
}
