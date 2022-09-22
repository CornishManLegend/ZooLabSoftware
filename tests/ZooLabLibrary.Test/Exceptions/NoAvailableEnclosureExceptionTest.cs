using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ZooLabLibrary.Exceptions;

namespace ZooLabLibrary.Test.Exceptions
{
    public class NoAvailableEnclosureExceptionTest
    {
        [Fact]
        public void ShouldBeAbleToCreateNoAvailableEnclosureException()
        {
            NoAvailableEnclosureException noAvailableEnclosureException = new NoAvailableEnclosureException();
            Assert.NotNull(noAvailableEnclosureException);
        }

        [Fact]
        public void ShouldBeAbleToCreateNoAvailableEnclosureExceptionWithMessage()
        {
            var stringWriter = new StringWriter();
            System.Console.SetOut(stringWriter);
            NoAvailableEnclosureException noAvailableEnclosureException = 
                new NoAvailableEnclosureException("No Available Enclosure Exception");
            var output = stringWriter.ToString();
            Assert.NotNull(noAvailableEnclosureException);
            Assert.Equal("No Available Enclosure Exception\n", output);
        }
    }
}
