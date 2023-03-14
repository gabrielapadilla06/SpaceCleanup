using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class InfoDialogController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text messageContainer;

    [SerializeField]
    public GameObject quizDialog;

    private QuizQuestion quizQuestion;

    // Start is called before the first frame update
    void Start()
    {
        messageContainer.text = "";
        gameObject.SetActive(false);
    }

    public void ShowDialog(QuizQuestion questionData)
    {
        quizQuestion = questionData;
        messageContainer.text = questionData.Message.Text;
        messageContainer.fontSize = questionData.Message.FontSize;
        Time.timeScale = 0f;
        gameObject.SetActive(true);
    }

    public void ShowQuiz()
    {
        EventSystem.current.SetSelectedGameObject(null); // Unfocus continue button
        gameObject.SetActive(false);
        quizDialog.SetActive(true);
        var infoDialogController = quizDialog.GetComponent<QuizDialogController>();
        infoDialogController.ShowDialog(quizQuestion);
    }
}
