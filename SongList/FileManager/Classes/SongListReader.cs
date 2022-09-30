using System;
using System.Collections.Generic;
using System.IO;

namespace FileManager.Classes
{
    public class SongListReader
    {
        public IEnumerable<Song> GetSongs()
        {
            var lines = File.ReadAllLines("Files/songs.csv");

            var list = new List<Song>();
            foreach (var line in lines)
            {
                var values = line.Split(";");
                list.Add(new Song()
                {
                    Artist = values[0]
                });
            }

            return list;
        }
    }
}

