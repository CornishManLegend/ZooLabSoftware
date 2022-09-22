using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Exceptions;

namespace ZooLabLibrary.Test.Exceptions
{
    public class NoAvailableSpaceExceptionTest
    {
        [Fact]
        public void ShouldBeAbleToCreateNoAvailableSpaceException()
        {
            NoAvailableSpaceException noAvailableSpaceException = new NoAvailableSpaceException();
            Assert.NotNull(noAvailableSpaceException);
        }

        [Fact]
        public void ShouldBeAbleToCreateNoAvailableSpaceExceptionWithMessage()
        {
            var stringWriter = new StringWriter();
            System.Console.SetOut(stringWriter);
            NoAvailableSpaceException noAvailableSpaceException =
                new NoAvailableSpaceException("No Available Space Exception");
            var output = stringWriter.ToString();
            Assert.NotNull(noAvailableSpaceException);
            Assert.Equal("No Available Space Exception\n", output);
        }
    }
}
