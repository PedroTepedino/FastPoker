public class Card
{
    public Suite Suite { get; }
    public Value Value { get; }

    public bool Hidden { get; private set; } = true;

    public Card(Suite suite, Value value)
    {
        Suite = suite;
        Value = value;
    }

    public void Reveal()
    {
        Hidden = false;
    }

    public void Hide()
    {
        Hidden = true;
    }

    public override string ToString()
    {
        return $"[ {this.Suite} - {this.Value} ]";
    }
}

public enum Suite
{
    CLUBS = 0,
    SPADES,
    DIAMONDS,
    HEART,
}

public enum Value
{
    ACE = 1, 
    TWO, 
    THREE,
    FOUR,
    FIVE,
    SIX, 
    SEVEN,
    EIGHT, 
    NINE, 
    TEN, 
    JACK, 
    QUEEN,
    KING,
}