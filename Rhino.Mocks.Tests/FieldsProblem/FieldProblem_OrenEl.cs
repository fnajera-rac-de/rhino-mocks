using System;
using System.Collections.Generic;
using Xunit;

namespace Rhino.Mocks.Tests.FieldsProblem
{

    public class FieldProblem_OrenEl
    {
        [Fact]
        public void GenericUnsignTypes()
        {
            IDictionary<ulong, ushort> stubClusterNodesMap = MockRepository.Mock<IDictionary<ulong, ushort>>();
            stubClusterNodesMap.SetUnexpectedBehavior(UnexpectedCallBehaviors.BaseOrDefault);
        }

        [Fact]
        public void IndexedProperties()
        {
            IDictionary<ulong, ushort> stubClusterNodesMap = MockRepository.Mock<IDictionary<ulong, ushort>>();
            stubClusterNodesMap.SetUnexpectedBehavior(UnexpectedCallBehaviors.BaseOrDefault);

            stubClusterNodesMap[UInt64.MaxValue] = UInt16.MinValue;
            Assert.Equal(UInt16.MinValue, stubClusterNodesMap[UInt64.MaxValue]);
        }
    }
}
