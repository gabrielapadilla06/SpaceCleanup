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
    private Button buttonA;
    
    [SerializeField]
    private Button buttonB;

    private QuizQuestion quizQuestion;

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
        if (clickedBtn == quizQuestion.CorrectAnswer)
        {

        }
        else
        {

        }
        ResumeGame();
    }

    private void ConfigureOptions()
    {
        var textA = buttonA.transform.GetChild(0).gameObject.GetComponent<TMP_Text>();
        textA.text = quizQuestion.Answers[AnswerBtn.A].Text;
        textA.fontSize = quizQuestion.Answers[AnswerBtn.A].FontSize;
        var textB = buttonB.transform.GetChild(0).gameObject.GetComponent<TMP_Text>();
        textB.text = quizQuestion.Answers[AnswerBtn.B].Text;
        textB.fontSize = quizQuestion.Answers[AnswerBtn.B].FontSize;
    }

    private void ResumeGame()
    {
        EventSystem.current.SetSelectedGameObject(null); // Unfocus clicked button
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
}
