using System.Windows.Forms;
using Xunit;

namespace Rhino.Mocks.Tests.FieldsProblem
{
    public class FieldProblem_Joe
    {
        [Fact]
        public void MockingConcreteForm()
        {
            Form frm = MockRepository.Partial<Form>();
            frm.SetUnexpectedBehavior(UnexpectedCallBehaviors.BaseOrDefault);
            Assert.NotNull(frm);
        }
    }
}
