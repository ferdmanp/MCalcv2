using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MCalcLib.exceptions
{
    [Serializable]
    public class InvalidBoundParameterException : Exception
    {
        public InvalidBoundParameterException() { }
        public InvalidBoundParameterException(string message) : base(message) { }
        public InvalidBoundParameterException(string message, Exception inner) : base(message, inner) { }
        protected InvalidBoundParameterException(
          SerializationInfo info,
          StreamingContext context)
            : base(info, context) { }
    }
}
