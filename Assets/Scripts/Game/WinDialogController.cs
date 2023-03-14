using Constants;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void RetryGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(UserScene.Game);
    }

    public void ReturnMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(UserScene.Menu);
    }
}
