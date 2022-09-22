using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Exceptions;

namespace ZooLabLibrary.Test.Exceptions
{
    public class NoNeededExperienceExceptionTest
    {
        [Fact]
        public void ShouldBeAbleToCreateNoNeededExperienceException()
        {
            NoNeededExperienceException noNeededExperienceException = new NoNeededExperienceException();
            Assert.NotNull(noNeededExperienceException);
        }

        [Fact]
        public void ShouldBeAbleToCreateNoAvailableSpaceExceptionWithMessage()
        {
            var stringWriter = new StringWriter();
            System.Console.SetOut(stringWriter);
            NoNeededExperienceException noNeededExperienceException =
                new NoNeededExperienceException("No Needed Experience Exception");
            var output = stringWriter.ToString();
            Assert.NotNull(noNeededExperienceException);
            Assert.Equal("No Needed Experience Exception\n", output);
        }
    }
}
