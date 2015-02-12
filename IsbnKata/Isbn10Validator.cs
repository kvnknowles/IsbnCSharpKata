using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbnKata
{
    public class Isbn10Validator : IIsbnValidator
    {
        public bool IsValid(string normalizedIsbn)
        {
            return normalizedIsbn.Length == 10 && ContainsValidCharacters(normalizedIsbn);
        }

        private static bool ContainsValidCharacters(string normalizedIsbn)
        {
            return normalizedIsbn.All(c => c >= '0' && c <= '9');
        }
    }
}
