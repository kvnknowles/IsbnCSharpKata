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

        private string NormalizeIsbn()
        {
            var normalizedIsbn = _isbn.Replace(" ", string.Empty);
            return normalizedIsbn.Replace("-", string.Empty);
        }
    }
}
