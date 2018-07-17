using System;

namespace TreehouseDefense
{
    public class OutOfBoundsException : Exception
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base (message)
        {

        }
    }
}
