﻿using IsbnKata;
using NUnit.Framework;

namespace IsbnKataTest
{
    [TestFixture]
    public class Isbn10Test
    {
        [Test]
        public void ValidIsbn10ReturnsTrue()
        {
            var isbn = new Isbn("0471958697", new Isbn13Validator());
            Assert.IsTrue(isbn.IsValidIsbn10());
        }

        [Test]
        public void StringLessThan10CharactersReturnsFalse()
        {
            var isbn = new Isbn("123456789", new Isbn13Validator());
            Assert.IsFalse(isbn.IsValidIsbn10());
        }

        [Test]
        public void StringMoreThan10CharactersReturnsFalse()
        {
            var isbn = new Isbn("12345678901", new Isbn13Validator());
            Assert.IsFalse(isbn.IsValidIsbn10());
        }

        [Test]
        public void ValidIsbn10WithSpacesReturnsTrue()
        {
            var isbn = new Isbn("0 4 7 1 9 5 8 6 9 7", new Isbn13Validator());
            Assert.IsTrue(isbn.IsValidIsbn10());
        }

        [Test]
        public void ValidIsbn10WithDashesReturnsTrue()
        {
            var isbn = new Isbn("0-4-7-1-9-5-8-6-9-7", new Isbn13Validator());
            Assert.IsTrue(isbn.IsValidIsbn10());
        }

        [Test]
        public void StringWithInvalidCharactersReturnsFalse()
        {
            var isbn = new Isbn("0A71B586C7", new Isbn13Validator());
            Assert.IsFalse(isbn.IsValidIsbn10());
        }

        /*[Test]
        public void InvalidIsbn10ReturnsFalse()
        {
            var isbn = new Isbn("0471958698");
            Assert.IsFalse(isbn.IsValidIsbn10());
        }*/
    }
}
