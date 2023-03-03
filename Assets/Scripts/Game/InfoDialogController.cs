using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class InfoDialogController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text textContainer;

    // Start is called before the first frame update
    void Start()
    {
        textContainer.text = "";
        gameObject.SetActive(false);
    }

    public void ShowDialog(InfoMessage infoMessage)
    {
        textContainer.text = infoMessage.Message;
        textContainer.fontSize = infoMessage.FontSize;
        Time.timeScale = 0f;
        gameObject.SetActive(true);
    }

    public void ResumeGame()
    {
        EventSystem.current.SetSelectedGameObject(null); // Unfocus continue button
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
}
