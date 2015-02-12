using System.Linq;

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
            var valid = false;
            if (ContainsValidCharacters(normalizedIsbn) && normalizedIsbn.Length == 13)
            {
                var checkSum = 0;
                var checkDigit = int.Parse(normalizedIsbn[12].ToString());
                for(var i = 1; i < 13; i++)
                {
                    var multiplier = (i%2 == 0) ? 3 : 1;
                    checkSum += multiplier*int.Parse(normalizedIsbn[i - 1].ToString());
                }
                checkSum = (10 - (checkSum %10)) %10;
                valid = (checkSum == checkDigit);
            }

            return valid;
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
    }
}
