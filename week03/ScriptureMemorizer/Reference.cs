public class Reference
{
    /* I applied the principle of encapsulation by making the variable only manipulatable within the class, in other words, writing the keyword private. */
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    /* I set up a constructor with three values, this only when the reference contains only ONE verse. */
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _verseEnd = verse;
    }

    /* On the other hand, this constructor will work when four values are given, since the reference contains TWO or MORE verses. */
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    /* This is the method I use to get the reference format. Depending on the reference/scripture, it will give me the chapter and the verse(s) that the user wants to memorize. */
    public string GetDisplayText()
    {
        if (_verseStart == _verseEnd)
            return $"{_book} {_chapter}:{_verseStart}";
        else
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
    }
}