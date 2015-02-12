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
            var isbn = new Isbn("0471958697");
            Assert.IsTrue(isbn.IsValidIsbn10());
        }

        [Test]
        public void StringLessThan10CharactersReturnsFalse()
        {
            var isbn = new Isbn("123456789");
            Assert.IsFalse(isbn.IsValidIsbn10());
        }
    }
}
