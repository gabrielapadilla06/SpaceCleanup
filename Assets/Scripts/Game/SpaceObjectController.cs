using UnityEngine;

public class SpaceObjectController : MonoBehaviour
{
    private float minX = -10.0f;
    public int maxHealth = 2;
    public int damage = 1; // Amount oƒ damage received
    public int damagePoints = 1; // Points earned for destroying the object

    private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
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

    // Takes damage and returns whether it has been destroyed or not.
    public bool TakeDamage()
    {
        currentHealth -= damage;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        
        if (currentHealth == 0)
        {
            Destroy(gameObject);
            return true;
        }
        return false;
    }
}
