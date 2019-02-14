using Challenge_Wed_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_Tests
{
    [TestClass]
    public class Wed_Challenge_1_Tests
    {
        StreamCityRepository _streamCityRepo;
        StreamCityContent _emptyContent;

        [TestInitialize]
        public void Arrange()
        {
            _streamCityRepo = new StreamCityRepository();
            _emptyContent = new StreamCityContent();
        }

        [TestMethod]
        public void StreamCityRepository_GetContentList_ShouldReturnCorrectCount()
        {
            //Arrange
            var contentList = _streamCityRepo.GetContentList();

            //Act
            var expected = 0;
            var actual = contentList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamCityRepository_AddContentToList_ShouldReturnCorrectCount()
        {
            //Arrange
            var contentList = _streamCityRepo.GetContentList();
            _streamCityRepo.AddContentToList(_emptyContent);

            //Act
            var actual = contentList.Count;
            var expected = 1;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamCityRepository_AddContentToList_ShouldContainCorrectContent()
        {
            StreamCityContent content = new StreamCityContent("Movie");
            StreamCityContent show = new StreamCityContent("Show");
            var contentList = _streamCityRepo.GetContentList();
            _streamCityRepo.AddContentToList(content);

            var expected = "Movie";
            var actual = contentList[0].Name;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamCityRepository_RemoveContentFromList_ShouldReturnCorrectCount()
        {
            //Arrange
            var content = new StreamCityContent();
            var contentList = _streamCityRepo.GetContentList();
            _streamCityRepo.AddContentToList(content);
            _streamCityRepo.RemoveContentFromList(content);

            //Act
            var actual = contentList.Count;
            var expected = 0;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        //Arrange
        [DataRow(1, GenreType.Action)]
        [DataRow(2, GenreType.Comedy)]
        [DataRow(3, GenreType.Thriller)]
        [DataRow(4, GenreType.Comedy)]
        public void StreamCityRepository_GetGenreFromInt_ShouldReturnCorrectGenre(int input, GenreType expected)
        {
            //Act
            var actual = _streamCityRepo.GetGenreFromInt(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamCityRepository_GetContentQueue_ShouldReturnCorrectCount()
        {
            //Arrange
            var contentQueue = _streamCityRepo.GetContentQueue();

            //Act
            var actual = contentQueue.Count;
            var expected = 0;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamCityRepository_AddContentToQueue_ShouldReturnCorrectCount()
        {
            //Arrange
            var contentQueue = _streamCityRepo.GetContentQueue();
            _streamCityRepo.AddContentToQueue(_emptyContent);

            //Act
            var actual = contentQueue.Count;
            var expected = 1;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamCityRepository_DequeueContentFromQueue_ShouldReturnCorrectCount()
        {
            //Arrange
            var contentQueue = _streamCityRepo.GetContentQueue();
            _streamCityRepo.AddContentToQueue(_emptyContent);
            _streamCityRepo.DequeueContentFromQueue();

            //Act
            var actual = contentQueue.Count;
            var expected = 0;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamCityRepository_DequeueContentFromQueue_ShouldRemoveFirstObject()
        {
            //Arrange
            var queue = _streamCityRepo.GetContentQueue();
            var contentOne = new StreamCityContent("Movie 1", 2.3, GenreType.Action, true);
            var contentTwo = new StreamCityContent("Movie 2", 4.5, GenreType.Thriller, true);
            _streamCityRepo.AddContentToQueue(contentOne);
            _streamCityRepo.AddContentToQueue(contentTwo);

            var expectedCount = 2;
            var actualCount = queue.Count;

            Assert.AreEqual(expectedCount, actualCount);

            _streamCityRepo.DequeueContentFromQueue();

            //Act
            var actual = queue.Peek().Name;
            var expected = "Movie 2";

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
