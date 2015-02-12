using IsbnKata;
using NUnit.Framework;

namespace IsbnKataTest
{
    [TestFixture]
    public class Isbn13Test
    {
        [Test]
        public void ValidIsbn13ReturnsTrue()
        {
            var isbn = new Isbn("9780470059029");
            Assert.IsTrue(isbn.IsValidIsbn13());
        }

        [Test]
        public void StringLessThan13CharactersReturnsFalse()
        {
            var isbn = new Isbn("012345678912");
            Assert.IsFalse(isbn.IsValidIsbn13());
        }

        [Test]
        public void StringMoreThan13CharactersReturnsFalse()
        {
            var isbn = new Isbn("01234567891234");
            Assert.IsFalse(isbn.IsValidIsbn13());
        }
    }
}
