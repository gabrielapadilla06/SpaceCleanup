using UnityEngine;

public class WinDialogController : MonoBehaviour
{
    [SerializeField]
    private AudioSource WinSound;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void ShowDialog()
    {
        Time.timeScale = 0f;
        gameObject.SetActive(true);
        WinSound.Play();
    }
}
