using System;
using System.Collections.Generic;
using Challenge_Tues_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_Tests
{
    [TestClass]
    public class TuesMorningTests
    {
        StreamingContentRepository _contentRepoTest = new StreamingContentRepository();

        [TestMethod]
        public void StreamingContentRepository_GetContentList_ShouldReturnCorrectCount()
        {
            //Arrange
            var contentList = _contentRepoTest.GetContentList();

            //Act
            var actual = contentList.Count;
            var expected = 0;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContentRepository_AddContentToList_ShouldReturnCorrectCount()
        {
            //Arrange
            List<StreamingContent> contentList = _contentRepoTest.GetContentList();
            StreamingContent content = new StreamingContent();

            //Act
            _contentRepoTest.AddContentToList(content);
            var actual = contentList.Count;
            var expected = 1;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContentRepository_RemoveContentFromList_ShouldDecreaseCountByOne()
        {
            //Arrange
            var content = new StreamingContent();
            var contentList = _contentRepoTest.GetContentList();
            _contentRepoTest.AddContentToList(content);

            //Act
            _contentRepoTest.RemoveContentFromList(content);
            var actual = contentList.Count;
            var expected = 0;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(1,GenreType.Action)]
        [DataRow(2,GenreType.Comedy)]
        [DataRow(3,GenreType.Thriller)]
        [DataRow(9,GenreType.Comedy)]
        public void StreamingContentRepository_GetGenreFromInt_ShouldReturnCorrectGenreType(int input, GenreType genre)
        {
            var actual = _contentRepoTest.GetGenreFromInt(input);
            var expected = genre;

            Assert.AreEqual(expected, actual);
        }
    }
}
