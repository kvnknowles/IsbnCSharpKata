﻿using IsbnKata;
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

        [Test]
        public void ValidIsbn13WithSpacesReturnsTrue()
        {
            var isbn = new Isbn("9 7 8 0 4 7 0 0 5 9 0 2 9");
            Assert.IsTrue(isbn.IsValidIsbn13());
        }

        [Test]
        public void ValidIsbn13WithDashesReturnsTrue()
        {
            var isbn = new Isbn("9-7-8-0-4-7-0-0-5-9-0-2-9");
            Assert.IsTrue(isbn.IsValidIsbn13());
        }

        [Test]
        public void StringContainingInvalidCharactersReturnsFalse()
        {
            var isbn = new Isbn("9A804B00C902D");
            Assert.IsFalse(isbn.IsValidIsbn13());
        }
    }
}
