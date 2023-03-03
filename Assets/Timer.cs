using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider slider;

    [SerializeField]
    public GameObject continueDialog;

    [SerializeField]
    public GameObject gameoverDialog;

    public int Duration;
    private int remainingDuratiion;

}
