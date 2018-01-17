using Xunit;

namespace Rhino.Mocks.Tests.FieldsProblem
{
    public class FieldProblem_Roger
    {
        [Fact]
        public void VerifyMockCanBeSetupWhenExternalInterfaceUsingInnerClassWithInternalScope()
        {
            ISomeInterface<InnerClass> target = MockRepository.Mock<ISomeInterface<InnerClass>>();
            target.SetUnexpectedBehavior(UnexpectedCallBehaviors.BaseOrDefault);
        }
    }

    internal class InnerClass
    {
    }

    public interface ISomeInterface<T>
    {
    }
}
