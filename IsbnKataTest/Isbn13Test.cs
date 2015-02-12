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
    }
}
