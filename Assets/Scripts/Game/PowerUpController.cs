using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public float startTime = 5.0f; // Seconds to wait before spawning objects 
    public float timeDelay = 8.0f; // Time delay between each object spawn
    public float minSpawnRadius = 2.0f;

    [SerializeField]
    private GameObject Battery;

    [SerializeField]
    private GameObject Shield;

    private GameObject[] objectPool;

    private float maxX = 12.0f;
    private float minY = -4.0f;
    private float maxY = 4.0f;

    void Start()
    {
        objectPool = new GameObject[] {
            Battery,
            Shield
        };
        InvokeRepeating(nameof(SpawnRandomObject), startTime, timeDelay);
    }

    void Update()
    {
        
    }

    private void SpawnRandomObject()
    {
        GameObject randomObject = PickRandomObject();
        Vector3 spawnPosition;
        do
        {
            spawnPosition = new Vector3(transform.position.x + maxX, transform.position.y + Random.Range(minY, maxY), 0);
        
        }
        while (Physics2D.OverlapCircle(spawnPosition, minSpawnRadius) != null);

        GameObject objectInstance = Instantiate(randomObject, spawnPosition, Quaternion.identity);
        objectInstance.GetComponent<Rigidbody2D>().velocity = Vector2.left * moveSpeed;
    }

    private GameObject PickRandomObject()
    {
        int randomIndex = UnityEngine.Random.Range(0, objectPool.Length);
        GameObject selectedObject = objectPool[randomIndex];
        return selectedObject;
    }
}
