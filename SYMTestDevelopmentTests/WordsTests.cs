using Microsoft.VisualStudio.TestTools.UnitTesting;
using SYMTestDevelopment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYMTestDevelopment.Tests
{
    [TestClass()]
    public class WordsTests
    {
        //Test Driven Development
        //As a developer, I want to be able to count occurences of a character in a string
        //"Mysterious"

        [TestMethod]
        public void FindSpecificCharacterTest()
        {
            //Arrange
            Word mysterious = new Word("mysterious");
            //Act
            var result = mysterious.FindSpecificCharacter("s");
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CountSpecificCharactersTest()
        {
            //Arrange
            Word mysterious = new Word("mysterious");
            //Act
            var result = mysterious.CountSpecificCharacters("s");
            //Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void CountSpecificCharacters0Test()
        {
            //Arrange
            Word mysterious = new Word("mysterious");
            //Act
            var result = mysterious.CountSpecificCharacters("l");
            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void CountAllCharactersTest()
        {
            //Arrange
            Word mysterious = new Word("mysterious");
            //Act
            var result = mysterious.CountAllCharacters();
            //Assert
            Assert.AreEqual(2, result);
        }
    }
}