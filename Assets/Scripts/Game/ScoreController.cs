using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text scoreLabel;

    [SerializeField]
    public GameObject winDialog;

    [SerializeField]
    public GameObject gameOverDialog;

    [SerializeField]
    private QuizGenerator quizGenerator;

    [SerializeField]
    private float timeBetweenQuestions = 20.0f;

    [SerializeField]
    private int totalQuestions = 4;

    private int displayedQuestionsCount = 0;

    private int correctAnswersCount = 0;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
    }

    // Adds bonus points for a correct answer.
    public void AddCorrectAnswerPoints(int bonusPoints)
    {
        correctAnswersCount++;
        AddPoints(bonusPoints);
    }

    // Adds bonus points.
    public void AddPoints(int bonusPoints)
    {
        score += bonusPoints;
        UpdateScore();
    }

    public bool HasQuizEnded()
    {
        return displayedQuestionsCount == totalQuestions;
    }

    public void RestartQuizTimer()
    {
        Invoke(nameof(ShowQuiz), timeBetweenQuestions);
    }

    public void ShowQuiz()
    {
        displayedQuestionsCount++;
        quizGenerator.ShowRandomQuestion();
    }

    public void ShowEndMessage()
    {
        if (correctAnswersCount == totalQuestions)
        {
            winDialog.GetComponent<WinDialogController>().ShowDialog();
        }
        else
        {
            gameOverDialog.GetComponent<GameOverController>().ShowDialog();
        }
    }

    private void UpdateScore()
    {
        scoreLabel.text = $"Puntuación: {score}";
    }
}
