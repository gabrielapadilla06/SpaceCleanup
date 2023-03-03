using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public Button ExitButton;

    private void Start()
    {
        ExitButton.onClick.AddListener(QuitButtonClicked);
    }

    private void QuitButtonClicked()
    {
        Application.Quit();
    }
}
