using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTests;

[TestClass]
public class FileManagerTests
{
    [TestMethod]
    public void SongListReader()
    {
        var reader = new FileManager.Classes.SongListReader();

        var songs = reader.GetSongs();

        Assert.AreEqual(200, songs.Count());
    }
}
