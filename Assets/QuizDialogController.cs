using Constants;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class QuizDialogController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text questionContainer;

    [SerializeField]
    private ScoreController scoreController;

    [SerializeField]
    private Button buttonA;

    [SerializeField]
    private Button buttonB;

    [SerializeField]
    private int correctAnswerBonus;

    [SerializeField]
    private Color buttonColor;

    [SerializeField]
    private Color correctButtonColor;

    [SerializeField]
    private Color wrongButtonColor;

    [SerializeField]
    private float showResultsTimeout = 1.0f; // In seconds

    private float resultsTimeScale = 0.01f; // Time scale to use when showing results
    private QuizQuestion quizQuestion;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void ShowDialog(QuizQuestion questionData)
    {
        quizQuestion = questionData;
        questionContainer.text = questionData.Question.Text;
        questionContainer.fontSize = questionData.Message.FontSize;
        ConfigureOptions();
    }

    public void HandleBtnA()
    {
        HandleAnswerClick(AnswerBtn.A);
    }

    public void HandleBtnB()
    {
        HandleAnswerClick(AnswerBtn.B);
    }

    private void HandleAnswerClick(AnswerBtn clickedBtn)
    {
        var isCorrectAnswer = clickedBtn == quizQuestion.CorrectAnswer;
        if (isCorrectAnswer)
        {
            scoreController.AddCorrectAnswerPoints(correctAnswerBonus);
        }
        ChangeButtonColor(clickedBtn, isCorrectAnswer);
        var scaledResultsTimeout = showResultsTimeout*resultsTimeScale;
        if (scoreController.HasQuizEnded())
        {
            Invoke(nameof(ShowEndMessage), scaledResultsTimeout);
        }
        else
        {
            Invoke(nameof(ResumeGame), scaledResultsTimeout);
        }
    }

    private void ChangeButtonColor(AnswerBtn clickedBtn, bool isCorrectAnswer)
    {
        EventSystem.current.SetSelectedGameObject(null); // Unfocus clicked button
        var newColor = isCorrectAnswer ? correctButtonColor : wrongButtonColor;
        if (clickedBtn == AnswerBtn.A)
        {
            buttonA.GetComponent<Image>().color = newColor;
        }
        else
        {
            buttonB.GetComponent<Image>().color = newColor;
        }
        Time.timeScale = resultsTimeScale;
    }

    private void ConfigureOptions()
    {
        ResetButtonColors();
        var textA = buttonA.transform.GetChild(0).gameObject.GetComponent<TMP_Text>();
        textA.text = quizQuestion.Answers[AnswerBtn.A].Text;
        textA.fontSize = quizQuestion.Answers[AnswerBtn.A].FontSize;
        var textB = buttonB.transform.GetChild(0).gameObject.GetComponent<TMP_Text>();
        textB.text = quizQuestion.Answers[AnswerBtn.B].Text;
        textB.fontSize = quizQuestion.Answers[AnswerBtn.B].FontSize;
    }

    private void ResetButtonColors()
    {
        buttonA.GetComponent<Image>().color = buttonColor;
        buttonB.GetComponent<Image>().color = buttonColor;
    }

    private void ShowEndMessage()
    {
        ResetButtonColors();
        scoreController.ShowEndMessage();
        gameObject.SetActive(false);
    }

    private void ResumeGame()
    {
        Time.timeScale = 1f;
        ResetButtonColors();
        scoreController.RestartQuizTimer();
        gameObject.SetActive(false);
    }
}
