namespace IsbnKata
{
    public interface IIsbnValidator
    {
        bool IsValid(string normalizedIsbn);
    }
}
