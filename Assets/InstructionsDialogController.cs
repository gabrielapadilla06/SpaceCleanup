using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsDialogController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void StartGame()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
}
