using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step234
{
    class LessThanOneException : Exception
    {
        public LessThanOneException()
    : base() { }
        public LessThanOneException(string message)
            : base(message) { }
    }
}
