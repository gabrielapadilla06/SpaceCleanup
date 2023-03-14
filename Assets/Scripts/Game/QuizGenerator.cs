using System.Collections.Generic;
using Constants;
using UnityEngine;

public class QuizGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject infoDialog;

    [SerializeField]
    private int maxDisplayedMessages = 3;

    [SerializeField]
    private float timeBetweenMessages = 2.0f;
    
    private int displayedMessagesCount = 0;
    private IList<QuizQuestion> remainingMessages;

    // Start is called before the first frame update
    void Start()
    {
        remainingMessages = new List<QuizQuestion>(Quiz.Questions);
        ResetGenerator();
    }

    // Reset the generation of messages at the start and after continue button is clicked
    public void ResetGenerator()
    {
        if (displayedMessagesCount < maxDisplayedMessages)
        {
            Invoke(nameof(ShowRandomMessage), timeBetweenMessages);
        }
    }

    private void ShowRandomMessage()
    {
        displayedMessagesCount++;
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
