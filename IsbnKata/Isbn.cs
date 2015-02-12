using System.Linq;

namespace IsbnKata
{
    public class Isbn
    {
        private readonly string _isbn;
        private readonly IIsbnValidator _validator;

        public Isbn(string isbn, IIsbnValidator validator)
        {
            this._isbn = isbn;
            this._validator = validator;
        }

        public bool IsValid()
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
