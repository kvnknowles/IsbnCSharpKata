using IsbnKata;
using NUnit.Framework;

namespace IsbnKataTest
{
    [TestFixture]
    public class Isbn10Test
    {
        [Test]
        public void ValidIsbn10ReturnsTrue()
        {
            var isbn = new Isbn("0471958697", new Isbn10Validator());
            Assert.IsTrue(isbn.IsValid());
        }

        [Test]
        public void StringLessThan10CharactersReturnsFalse()
        {
            var isbn = new Isbn("123456789", new Isbn10Validator());
            Assert.IsFalse(isbn.IsValid());
        }

        [Test]
        public void StringMoreThan10CharactersReturnsFalse()
        {
            var isbn = new Isbn("12345678901", new Isbn10Validator());
            Assert.IsFalse(isbn.IsValid());
        }

        [Test]
        public void ValidIsbn10WithSpacesReturnsTrue()
        {
            var isbn = new Isbn("0 4 7 1 9 5 8 6 9 7", new Isbn10Validator());
            Assert.IsTrue(isbn.IsValid());
        }

        [Test]
        public void ValidIsbn10WithDashesReturnsTrue()
        {
            var isbn = new Isbn("0-4-7-1-9-5-8-6-9-7", new Isbn10Validator());
            Assert.IsTrue(isbn.IsValid());
        }

        [Test]
        public void StringWithInvalidCharactersReturnsFalse()
        {
            var isbn = new Isbn("0A71B586C7", new Isbn10Validator());
            Assert.IsFalse(isbn.IsValid());
        }

        [Test]
        public void InvalidIsbn10ReturnsFalse()
        {
            var isbn = new Isbn("0471958698", new Isbn10Validator());
            Assert.IsFalse(isbn.IsValid());
        }

        [Test]
        public void ValidIsbn10EndingInXReturnsTrue()
        {
            var isbn = new Isbn("156881111X", new Isbn10Validator());
            Assert.IsTrue(isbn.IsValid());
        }

        [Test]
        public void ValidIsbn10EndingInXIgnoresCaseAndReturnsTrue()
        {
            var isbn = new Isbn("156881111x", new Isbn10Validator());
            Assert.IsTrue(isbn.IsValid());
        }
    }
}
