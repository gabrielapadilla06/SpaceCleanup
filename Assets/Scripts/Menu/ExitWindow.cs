using UnityEngine;
using UnityEngine.UI;

public class ExitWindow : MonoBehaviour
{
    [SerializeField]
    public GameObject ConfirmWindow;
    [SerializeField]
    public Button noButton;

    [SerializeField]
    private AudioSource ButtonSound;

    private void Start()
    {
        noButton.onClick.AddListener(CloseWindow);
    }

    private void CloseWindow()
    {
        ConfirmWindow.SetActive(false);
    }
}
