using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public float startTime = 5.0f; // Seconds to wait before spawning objects 
    public float timeDelay = 5.0f; // Time delay between each object spawn
    public float minSpawnRadius = 2.0f;

    [SerializeField]
    private GameObject Battery;

    private float maxX = 12.0f;
    private float minY = -4.0f;
    private float maxY = 4.0f;

    void Start()
    {
        InvokeRepeating(nameof(BatteryObject), startTime, timeDelay);
    }

    void Update()
    {
        
    }

    private void BatteryObject()
    {
        GameObject lifeObject = Battery;
        Vector3 spawnPosition;
        do
        {
            spawnPosition = new Vector3(transform.position.x + maxX, transform.position.y + Random.Range(minY, maxY), 0);
        
        }
        while (Physics2D.OverlapCircle(spawnPosition, minSpawnRadius) != null);

        GameObject objectInstance = Instantiate(lifeObject, spawnPosition, Quaternion.identity);
        objectInstance.GetComponent<Rigidbody2D>().velocity = Vector2.left * moveSpeed;

    }
}
