using System.Linq;

namespace IsbnKata
{
    static internal class IsbnHelper
    {
        internal static bool ContainsOnlyDigits(string normalizedIsbn)
        {
            return normalizedIsbn.All(c => c >= '0' && c <= '9');
        }
    }
}