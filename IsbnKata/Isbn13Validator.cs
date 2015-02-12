using System;
using System.Linq;

namespace IsbnKata
{
    public class Isbn13Validator : IIsbnValidator
    {
        private const int EvenMultiplier = 3;
        private const int OddMultiplier = 1;

        public bool IsValid(string normalizedIsbn)
        {
            return ContainsValidCharacters(normalizedIsbn) && normalizedIsbn.Length == 13 && CheckSumMatchesCheckDigit(normalizedIsbn);
        }

        private static bool ContainsValidCharacters(string normalizedIsbn)
        {
            return IsbnHelper.ContainsOnlyDigits(normalizedIsbn);
        }

        private static bool CheckSumMatchesCheckDigit(string normalizedIsbn)
        {
            var checkDigit = int.Parse(normalizedIsbn[12].ToString());
            var checkSum = CalculateCheckSum(normalizedIsbn);
            return checkSum == checkDigit;
        }

        private static int CalculateCheckSum(string normalizedIsbn)
        {
            var checkSum = 0;
            for (var i = 1; i < 13; i++)
            {
                var multiplier = (IsEven(i)) ? EvenMultiplier : OddMultiplier;
                checkSum += multiplier * int.Parse(normalizedIsbn[i - 1].ToString());
            }
            checkSum = (10 - (checkSum % 10)) % 10;
            return checkSum;
        }

        private static bool IsEven(int i)
        {
            return i % 2 == 0;
        }
    }
}
