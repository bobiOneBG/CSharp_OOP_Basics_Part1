namespace _04_OnlineRadioDatabase_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            {
                var songCount = int.Parse(Console.ReadLine());

                var songs = new List<Song>();

                GetSongs(songCount, songs);

                Console.WriteLine($"Songs added: {songs.Count}");

                var summaryTime = CalculateTime(songs);

                Console.WriteLine($"Playlist length: {summaryTime.Hours}h {summaryTime.Minutes}m {summaryTime.Seconds}s");
            }
        }


        private static void GetSongs(int songCount, List<Song> songs)
        {
            for (int cntr = 0; cntr < songCount; cntr++)
            {
                var songInfo = Console.ReadLine().Split(';');

                try
                {
                    if (songInfo.Length != 3)
                    {
                        throw new ArgumentException();
                    }

                    string artistName = songInfo[0];
                    string songName = songInfo[1];
                    string duration = songInfo[2];

                    var durationInfo = duration.Split(':');

                    if (int.TryParse(durationInfo[0], out int minutes) &&
                        int.TryParse(durationInfo[1], out int seconds))
                    {
                        var song = new Song(artistName, songName, minutes, seconds); songs.Add(song);
                        Console.WriteLine("Song added.");
                    }
                    else
                        throw new InvalidSongLengthException();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static TimeSpan CalculateTime(List<Song> songs)
        {
            var seconds = songs.Sum(s => s.Seconds);
            var minutes = songs.Sum(m => m.Minutes);
            TimeSpan span = new TimeSpan(0, minutes, seconds);
            return span;
        }
    }
}
