using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace IsbnKata
{
    public class Isbn10Validator : IIsbnValidator
    {
        public bool IsValid(string normalizedIsbn)
        {
            return normalizedIsbn.Length == 10 && ContainsValidCharacters(normalizedIsbn) && CheckSumMatchesCheckDigit(normalizedIsbn);
        }

        private static bool CheckSumMatchesCheckDigit(string normalizedIsbn)
        {
            var checkDigit = -1;
            checkDigit = EndsInX(normalizedIsbn) ? 10 : int.Parse(normalizedIsbn[9].ToString());
            var checkSum = 0;
            for (var i = 1; i < 10; i++)
            {
                checkSum += i * int.Parse(normalizedIsbn[i-1].ToString());
            }
            checkSum = checkSum%11;
            return checkSum == checkDigit;
        }

        private static bool EndsInX(string normalizedIsbn)
        {
            return normalizedIsbn.ToUpper().Last() == 'X';
        }

        private static bool ContainsValidCharacters(string normalizedIsbn)
        {
            return IsbnHelper.ContainsOnlyDigits(GetDigitsToCheck(normalizedIsbn));
        }

        private static string GetDigitsToCheck(string normalizedIsbn)
        {
            return EndsInX(normalizedIsbn) ? normalizedIsbn.Substring(0, 9) : normalizedIsbn;
        }
    }
}
