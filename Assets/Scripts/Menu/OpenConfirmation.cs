using UnityEngine;
using UnityEngine.UI;

public class OpenConfirmation : MonoBehaviour
{
    [SerializeField]
    public GameObject ConfirmWindow;
    [SerializeField]
    public Button ExitButton;

    private void Start()
    {
        ExitButton.onClick.AddListener(OpenPrefab);
    }

    private void OpenPrefab()
    {
        Instantiate(ConfirmWindow);
    }
}
