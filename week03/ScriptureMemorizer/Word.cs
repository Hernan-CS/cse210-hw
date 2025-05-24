public class Word
{
    /* Encapsulation applied as well. */
    private string _text;
    private bool _isHidden;

    /* This constructor accepts a string, which I actually used later in the Scripture class. 
    Also, I set the boolean variable as false called isHidden, what is, in fact, a vital part 
    of other loops and mainly for the process of hiding a word. */
    public Word(string text)
    {
        _text = text;
        /* By default, the word is visible. */
        _isHidden = false;
    }

    /* Method to set the value of the boolean variable as true, that is, to say that it's invisible. */
    public void Hide()
    {
        _isHidden = true;
    }

    /* Method to use the value of the boolean variable called isHidden, that's it. */
    public bool IsHidden()
    {
        return _isHidden;
    }

    /* And if-statement used to run a code if isHidden is true, that is, it's hidden so it just shows it. 
    This will replace the text that was marked as hidden with "_" and the ones that are not hidden will be normally show. */
    public string GetDisplayText()
    {
        if (_isHidden)
            return new string('_', _text.Length);
        else
            return _text;
    }
}