using System.Collections.Generic;
using Constants;

public class QuizQuestion
{
    public QuizLabel Message { get; set; }
    public QuizLabel Question { get; set; }
    public Dictionary<AnswerBtn, QuizLabel> Answers { get; set; }
    public AnswerBtn CorrectAnswer { get; set; }

    public QuizQuestion(
        QuizLabel message,
        QuizLabel question,
        Dictionary<AnswerBtn, QuizLabel> answers,
        AnswerBtn correctAnswer)
    {
        Message = message;
        Question = question;
        Answers = answers;
        CorrectAnswer = correctAnswer;
    }
}