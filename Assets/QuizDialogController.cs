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
    private float showResultsTimeout = 1.0f;

    [SerializeField]
    private Color buttonColor;

    [SerializeField]
    private Color correctButtonColor;

    [SerializeField]
    private Color wrongButtonColor;

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
            scoreController.AddAnswerBonus(correctAnswerBonus);
        }
        ChangeButtonColor(clickedBtn, isCorrectAnswer);
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
        Invoke(nameof(ResumeGame), showResultsTimeout*resultsTimeScale);
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

    private void ResumeGame()
    {
        ResetButtonColors();
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
}
