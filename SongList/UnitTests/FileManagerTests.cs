using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests;

[TestClass]
public class FileManagerTests
{
    [TestMethod]
    public void SongListReader()
    {
        var reader = new FileManager.Classes.SongListReader();

        var songs = reader.GetSongs();
    }
}
