namespace _03.RangeExceptions
{
    using System;
    public class InvalidRangeException<T> : ApplicationException
    {
        public const string InvalidValueInRangeFormat = "Value must be in range {0} - {1}";
        private T start;
        private T end;

        public InvalidRangeException(string message, Exception exc)
            : base(message, exc)
        {

        }

        public InvalidRangeException(string message)
            : this(message, null)
        {

        }
        
        public T Start
        {
            get
            {
                return this.start;
            }
            private set
            {
                this.start = value;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }
            private set
            {
                this.end = value;
            }
        }

    }
}
