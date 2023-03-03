using System.Collections.Generic;
using Constants;
using UnityEngine;

public class InfoGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject infoDialog;

    [SerializeField]
    private int maxDisplayedMessages = 3;

    [SerializeField]
    private float timeBetweenMessages = 2.0f;
    
    private int displayedMessagesCount = 0;
    private IList<InfoMessage> remainingMessages;

    // Start is called before the first frame update
    void Start()
    {
        remainingMessages = new List<InfoMessage>(Data.InfoMessages);
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
            var selectedMessage = PickRandomMessage();
            var infoDialogController = infoDialog.GetComponent<InfoDialogController>();
            infoDialogController.ShowDialog(selectedMessage);
        }
    }

    private InfoMessage PickRandomMessage()
    {
        int randomIndex = UnityEngine.Random.Range(0, remainingMessages.Count);
        var selectedMessage = remainingMessages[randomIndex];
        remainingMessages.RemoveAt(randomIndex);
        return selectedMessage;
    }
}
