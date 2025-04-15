namespace Challenge.BolivarJimenez.Common;
public static class Common
{
    public static readonly Dictionary<string, List<string>> KeyPad = new()
    {
        {"1", new(){"&","'", "(" }},
        {"2", new(){"A","B", "C" }},
        {"3", new(){"D", "E", "F" }},
        {"4", new(){"G", "H", "I" }},
        { "5", new(){"J", "K", "L" }},
        { "6", new(){"M", "N", "O" }},
        { "7", new(){"P", "Q","R","S" }},
        { "8", new(){"T", "U", "V" }},
        { "9", new(){"W", "X", "Y","Z" }},
        { "0", new(){"_" }},    // An underscore is used in place of a space to simulate a time delay.
        { "*", new(){"*"}},     // Del key
        { "#", new(){"#" }},    // Send key
    };
}
