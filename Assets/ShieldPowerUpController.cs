using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPowerUpController : MonoBehaviour
{
    public float activationTime = 3f;
    private float minX = -10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var positionX = transform.position.x;
        if (positionX <= minX)
        {
            Destroy(gameObject);
        }
    }
}
