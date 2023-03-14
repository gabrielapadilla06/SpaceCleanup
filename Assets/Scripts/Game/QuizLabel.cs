// Class to control any quiz label.
public class QuizLabel
{
    public string Text { get; set; }
    public float FontSize { get; set; }

    public QuizLabel(string text, float fontSize = 80)
    {
        Text = text;
        FontSize = fontSize;
    }
}