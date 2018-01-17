using Xunit;

namespace Rhino.Mocks.Tests.FieldsProblem
{
    public class FieldProblem_DavidG
    {
        [Fact]
        public void GenericConstrainedMethod()
        {
            IStore1 store1 = MockRepository.Mock<IStore1>();
            store1.SetUnexpectedBehavior(UnexpectedCallBehaviors.BaseOrDefault);
            IStore2 store2 = MockRepository.Mock<IStore2>();
            store2.SetUnexpectedBehavior(UnexpectedCallBehaviors.BaseOrDefault);
            Assert.NotNull(store2);
            Assert.NotNull(store1);
        }
    }

    public interface IStore1
    {
        R[] TestMethod<R>();
    }

    public interface IStore2
    {
        R[] TestMethod<R>() where R : DomainObject<R>;
    }

    public class MyTestObject : DomainObject<MyTestObject>
    {
    }

    public abstract class DomainObject<T> where T : DomainObject<T>
    {
    }
}
