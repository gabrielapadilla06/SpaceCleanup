using System.Collections.Generic;
using Constants;
using UnityEngine;

public class QuizGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject infoDialog;
  
    private IList<QuizQuestion> remainingQuestions;

    // Start is called before the first frame update
    void Start()
    {
        remainingQuestions = new List<QuizQuestion>(Quiz.Questions);
    }

    public void ShowRandomQuestion()
    {
        if (remainingQuestions.Count > 0)
        {
            var selectedQuestion = PickRandomQuestion();
            var infoDialogController = infoDialog.GetComponent<InfoDialogController>();
            infoDialogController.ShowDialog(selectedQuestion);
        }
    }

    private QuizQuestion PickRandomQuestion()
    {
        int randomIndex = UnityEngine.Random.Range(0, remainingQuestions.Count);
        var selectedMessage = remainingQuestions[randomIndex];
        remainingQuestions.RemoveAt(randomIndex);
        return selectedMessage;
    }
}
