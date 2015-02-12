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
            return IsbnHelper.ContainsOnlyDigits(normalizedIsbn);
        }
    }
}
