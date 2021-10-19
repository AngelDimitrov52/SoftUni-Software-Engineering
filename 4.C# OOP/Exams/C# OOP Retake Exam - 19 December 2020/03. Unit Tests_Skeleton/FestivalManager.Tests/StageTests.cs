// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
    using FestivalManager.Entities;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class StageTests
    {
        private Stage stage;
        private Performer performer;
        private Song song;

        [SetUp]
        public void Setup()
        {
            stage = new Stage();
            performer = new Performer("Angel", "Dany", 34);
            song = new Song("Game", new TimeSpan(1, 45, 12));
        }

        [Test]
        public void Ctor_test()
        {

            Assert.That(stage.Performers != null);
        }

        [Test]
        public void AddPerformer_ThorowEx_WhenAgeIsLessThan18()
        {
            performer = new Performer("Angel", "Dany", 13);
            Assert.Throws<ArgumentException>(() => stage.AddPerformer(performer));
        }
        [Test]
        public void AddPerformer_ThorowEx_WhenIsNull()
        {
            performer = null;
            Assert.Throws<ArgumentNullException>(() => stage.AddPerformer(performer));
        }
        [Test]
        public void AddPerformer_Work()
        {
            stage.AddPerformer(performer);
            Assert.AreEqual(stage.Performers.Count, 1);

        }
        [Test]
        public void AddSong_ThrowEx_WhenSongIsLesThan1()
        {
            song = new Song("Game", new TimeSpan(0, 0, 12));
            Assert.Throws<ArgumentException>(() => stage.AddSong(song));
        }

        [Test]
        public void AddSongToPerfomer_Work()
        {
            stage.AddSong(song);
            stage.AddPerformer(performer);
            string result = stage.AddSongToPerformer("Game", "Angel Dany");
            Assert.AreEqual(result, $"{song.ToString()} will be performed by {performer.FullName}");
            Assert.AreEqual(performer.SongList.Count, 1);
        }
        [Test]
        public void Play_Work()
        {
            stage.AddSong(song);
            stage.AddPerformer(performer);
            stage.AddSongToPerformer("Game", "Angel Dany");

            string result = stage.Play();

            Assert.AreEqual(result, $"{stage.Performers.Count} performers played {1} songs");

        }
        [Test]
        public void GetPerformer_ThworWhenNullPerformer()
        {
            stage.AddSong(song);
            stage.AddPerformer(performer);

            Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer("Game", "Angel"));

        }
        [Test]
        public void GetSong_ThworWhenNullPerformer()
        {
            stage.AddSong(song);
            stage.AddPerformer(performer);

            Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer("nogame", "Angel Dany"));

        }



    }
}