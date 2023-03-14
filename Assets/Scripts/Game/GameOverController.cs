using Constants;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    [SerializeField]
    private AudioSource GameOverSound;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void ShowDialog()
    {
        Time.timeScale = 0f;
        gameObject.SetActive(true);
        GameOverSound.Play();
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
