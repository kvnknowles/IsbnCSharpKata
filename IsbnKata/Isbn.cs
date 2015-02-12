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
            return _isbn.Length == 13;
        }
    }
}
