using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCalcLib.exceptions
{

    [Serializable]
    public class InvalidStandardException : Exception
    {
        public InvalidStandardException() { }
        public InvalidStandardException(string message) : base(message) { }
        public InvalidStandardException(string message, Exception inner) : base(message, inner) { }
        protected InvalidStandardException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
