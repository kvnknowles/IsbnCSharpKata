using System.Linq;

namespace IsbnKata
{
    public class Isbn
    {
        private const int EvenMultiplier = 3;
        private const int OddMultiplier = 1;
        private readonly string _isbn;

        public Isbn(string isbn)
        {
            this._isbn = isbn;
        }

        public bool IsValidIsbn13()
        {
            return new Isbn13Validator().IsValid(NormalizeIsbn());
        }

        private static bool ContainsValidCharacters(string normalizedIsbn)
        {
            return normalizedIsbn.All(c => c >= '0' && c <= '9');
        }

        private string NormalizeIsbn()
        {
            var normalizedIsbn = _isbn.Replace(" ", string.Empty);
            return normalizedIsbn.Replace("-", string.Empty);
        }

        public bool IsValidIsbn10()
        {
            return NormalizeIsbn().Length == 10 && ContainsValidCharacters(NormalizeIsbn());
        }
    }
}
