using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLabLibrary.Exceptions;

namespace ZooLabLibrary.Test.Exceptions
{
    public class NotFriendlyAnimalExceptionTest
    {
        [Fact]
        public void ShouldBeAbleToCreateNotFriendlyAnimalException()
        {
            NotFriendlyAnimalException notFriendlyAnimalException = new NotFriendlyAnimalException();
            Assert.NotNull(notFriendlyAnimalException);
        }

        [Fact]
        public void ShouldBeAbleToCreateNotFriendlyAnimalExceptionWithMessage()
        {
            var stringWriter = new StringWriter();
            System.Console.SetOut(stringWriter);
            NotFriendlyAnimalException notFriendlyAnimalException =
                new NotFriendlyAnimalException("Not Friendly Animal Exception");
            var output = stringWriter.ToString();
            Assert.NotNull(notFriendlyAnimalException);
            Assert.Equal("Not Friendly Animal Exception\n", output);
        }
    }
}
