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
    }
}
