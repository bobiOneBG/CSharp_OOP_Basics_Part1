namespace _04_OnlineRadioDatabase_
{
    using System;

    public class InvalidSongException : Exception
    {
        public override string Message
        {
            get { return "Invalid song."; }
        }
    }
}
