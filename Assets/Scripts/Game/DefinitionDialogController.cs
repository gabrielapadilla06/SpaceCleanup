using UnityEngine;

public class DefinitionDialogController : MonoBehaviour
{
    [SerializeField]
    private ScoreController scoreController;

    // Update is called once per frame
    public void StartGame()
    {
        Time.timeScale = 1f;
        scoreController.RestartQuizTimer();
        gameObject.SetActive(false);
    }
}
