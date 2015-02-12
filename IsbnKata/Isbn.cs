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

            var containsValidCharacters = true;

            foreach (char c in normalizedIsbn)
            {
                if (c < '0' || c > '9')
                {
                    containsValidCharacters = false;
                }
            }

            return containsValidCharacters && normalizedIsbn.Length == 13;
        }

        private string NormalizeIsbn()
        {
            var normalizedIsbn = _isbn.Replace(" ", string.Empty);
            return normalizedIsbn.Replace("-", string.Empty);
        }
    }
}
