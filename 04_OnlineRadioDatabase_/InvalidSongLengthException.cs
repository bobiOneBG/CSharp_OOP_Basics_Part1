namespace _04_OnlineRadioDatabase_
{
    using System;

    public class InvalidSongLengthException : Exception
    {
        public override string Message
        {
            get { return "Invalid song length."; }
        }
    }
}
