
using System.IO;
using Rhino.Mocks.Loggers;
using Xunit;

namespace Rhino.Mocks.Tests
{
    public class TraceWriterWithStackTraceExpectationWriterFixture
    {
        [Fact]
        public void WillPrintLogInfoWithStackTrace()
        {
            TraceWriterWithStackTraceLogger expectationWriter = new TraceWriterWithStackTraceLogger();
            StringWriter writer = new StringWriter();
            expectationWriter.AlternativeWriter = writer;

            RhinoMocks.Logger = expectationWriter;

            IDemo mock = MockRepository.Mock<IDemo>();
            mock.SetUnexpectedBehavior(UnexpectedCallBehaviors.BaseOrDefault);
            mock.Expect(x => x.VoidNoArgs());

            mock.VoidNoArgs();

            Assert.Contains("WillPrintLogInfoWithStackTrace",
                writer.GetStringBuilder().ToString());

            mock.VerifyExpectations();
        }
    }
}