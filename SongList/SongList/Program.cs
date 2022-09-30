using System;


namespace SongList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var reader = new FileManager.Classes.SongListReader();

            var songs = reader.GetSongs();

            Console.WriteLine($"Number of songs: {songs.Count()}");
        }
    }
}

