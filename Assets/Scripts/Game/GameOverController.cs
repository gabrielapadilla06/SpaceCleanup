using Constants;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    private void Start()
    {
        //gameObject.SetActive(false);
    }

   // public void EndOfGame()
    //{
        //Time.timeScale = 0f;
        //gameObject.SetActive(true);
    //}

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
