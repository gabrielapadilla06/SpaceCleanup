using System.Collections;
using Constants;
using UnityEngine;
using UnityEngine.UI;

public class TimerDialogController : MonoBehaviour
{

    [SerializeField]
    public GameObject gameoverDialog;

    [SerializeField]
    public GameObject quizDialog;  


    void Start()
    {
        gameoverDialog.SetActive(false);
        quizDialog.SetActive(false);
    }


    public void Yes()
    {
        quizDialog.SetActive(true);
        gameObject.SetActive(false);
    }

    public void No()
    {
        gameoverDialog.SetActive(true);
        gameObject.SetActive(false);
    }
}
