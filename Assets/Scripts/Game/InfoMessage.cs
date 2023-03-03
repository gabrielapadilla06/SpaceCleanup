public class InfoMessage
{
    public string Message { get; set; }
    public float FontSize { get; set; }

    public InfoMessage(string message, float fontSize = 80)
    {
        Message = message;
        FontSize = fontSize;
    }
}