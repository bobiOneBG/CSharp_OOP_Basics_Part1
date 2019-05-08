namespace _04_OnlineRadioDatabase_
{
    public class InvalidSongMinutesException : InvalidSongException
    {
        public override string Message
        {
            get
            {
                return "Song minutes should be between 0 and 14.";
            }
        }
    }
}
