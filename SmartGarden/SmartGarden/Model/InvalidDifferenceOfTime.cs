﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    class InvalidDifferenceOfTime : Exception
    {
        public InvalidDifferenceOfTime() : base() { }
        public InvalidDifferenceOfTime(string message) : base(message) { }
        public InvalidDifferenceOfTime(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected InvalidDifferenceOfTime(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
