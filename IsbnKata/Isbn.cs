namespace IsbnKata
{
    public class Isbn
    {
        private readonly string _isbn;

        public Isbn(string isbn)
        {
            this._isbn = isbn;
        }

        public bool IsValidIsbn13()
        {
            var normalizedIsbn = NormalizeIsbn();
            return normalizedIsbn.Length == 13;
        }

        private string NormalizeIsbn()
        {
            var normalizedIsbn = _isbn.Replace(" ", string.Empty);
            normalizedIsbn = normalizedIsbn.Replace("-", string.Empty);
            return normalizedIsbn;
        }
    }
}
