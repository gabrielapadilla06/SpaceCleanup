using System.Collections.Generic;
using Constants;
using UnityEngine;

public class QuizGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject infoDialog;
    
    [SerializeField]
    private ScoreController scoreController;

    [SerializeField]
    private float timeBetweenMessages = 2.0f;
    
    private IList<QuizQuestion> remainingMessages;

    // Start is called before the first frame update
    void Start()
    {
        remainingMessages = new List<QuizQuestion>(Quiz.Questions);
        ResetGenerator();
    }

    // Reset the generation of messages at the start and after continue button is clicked.
    // If it should not display more questions, show end message.
    public void ResetGenerator()
    {
        if (scoreController.ShouldDisplayQuestions())
        {
            Invoke(nameof(ShowRandomMessage), timeBetweenMessages);
        }
        else
        {
            scoreController.DisplayEndMessage();
        }
    }

    private void ShowRandomMessage()
    {
        scoreController.UpdateQuestionCounter();
        if (remainingMessages.Count > 0)
        {
            var selectedQuestion = PickRandomQuestion();
            var infoDialogController = infoDialog.GetComponent<InfoDialogController>();
            infoDialogController.ShowDialog(selectedQuestion);
        }
    }

    private QuizQuestion PickRandomQuestion()
    {
        int randomIndex = UnityEngine.Random.Range(0, remainingMessages.Count);
        var selectedMessage = remainingMessages[randomIndex];
        remainingMessages.RemoveAt(randomIndex);
        return selectedMessage;
    }
}
