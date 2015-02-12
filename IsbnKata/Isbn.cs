using System.Linq;

namespace IsbnKata
{
    public class Isbn
    {
        private readonly string _isbn;
        private readonly Isbn13Validator _validator;

        public Isbn(string isbn)
        {
            this._isbn = isbn;
            this._validator = new Isbn13Validator();
        }

        public bool IsValidIsbn13()
        {
            return _validator.IsValid(NormalizeIsbn());
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
