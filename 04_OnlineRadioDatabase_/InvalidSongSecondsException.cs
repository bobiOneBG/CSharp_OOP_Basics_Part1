namespace _04_OnlineRadioDatabase_
{
    public class InvalidSongSecondsException : InvalidSongException
    {
        public override string Message
        {
            get { return "Song seconds should be between 0 and 59."; }
        }
    }
}
