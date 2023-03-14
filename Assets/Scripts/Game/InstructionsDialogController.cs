using UnityEngine;

public class InstructionsDialogController : MonoBehaviour
{
    [SerializeField]
    public GameObject defDialog;
    // Start is called before the first frame update
    void Start()
    {
        defDialog.SetActive(false);
    }

    // Update is called once per frame
    public void StartGame()
    {
        Time.timeScale = 0f;
        gameObject.SetActive(false);
        defDialog.SetActive(true);
    }
}
