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
    private int totalQuestions = 4;

    private int displayedQuestionsCount = 0;

    private int correctAnswersCount = 0;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
    }

    public void AddPoints(int points)
    {
        score += points;
        UpdateScore();
    }

    public bool ShouldDisplayQuestions()
    {
        return displayedQuestionsCount < totalQuestions;
    }

    // Updates the displayed question counter.
    public void UpdateQuestionCounter()
    {
        displayedQuestionsCount++;
    }
   
    // Adds bonus for a correct answer.
    public void AddAnswerBonus(int bonus)
    {
        correctAnswersCount++;
        score += bonus;
        UpdateScore();
    }

    public void DisplayEndMessage()
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
