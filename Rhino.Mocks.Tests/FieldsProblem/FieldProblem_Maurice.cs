using Xunit;

namespace Rhino.Mocks.Tests.FieldsProblem
{
    public class FieldProblem_Maurice
    {
        [Fact]
        public void TwoGenericParametersWithConstraints()
        {
            IDemo2 demo = MockRepository.Mock<IDemo2>();
            demo.SetUnexpectedBehavior(UnexpectedCallBehaviors.BaseOrDefault);
            Assert.NotNull(demo);
        }
    }

    public interface IDemo2
    {
        T CreateRequest<T, R>()
            where T : Request<R>
            where R : Response;
    }

    public class Request<T> where T : Response
    {
    }

    public class Response
    {
    }
}
