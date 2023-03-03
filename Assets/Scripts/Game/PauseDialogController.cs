using Constants;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseDialogController : MonoBehaviour
{

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        gameObject.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }

    public void ReturnMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(UserScene.Menu);
    }
}
