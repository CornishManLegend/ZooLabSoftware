using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLabLibrary.Exceptions
{
    public class NoNeededExperienceException : Exception
    {
        public NoNeededExperienceException() { }

        public NoNeededExperienceException(string message)
            : base(message) { }
    }
}