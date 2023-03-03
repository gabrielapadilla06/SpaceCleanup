using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeObjectController : MonoBehaviour
{   
    private float minX = -10.0f;
    // Start is called before the first frame update
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
