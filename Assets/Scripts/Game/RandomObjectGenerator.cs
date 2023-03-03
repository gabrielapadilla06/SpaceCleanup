using UnityEngine;

public class RandomObjectGenerator : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public float startTime = 5.0f; // Seconds to wait before spawning objects 
    public float timeDelay = 2.0f; // Time delay between each object spawn
    public float minSpawnRadius = 2.0f;

    [SerializeField]
    private GameObject meteorite1;
    [SerializeField]
    private GameObject meteorite2;
    [SerializeField]
    private GameObject meteorite3;
    [SerializeField]
    private GameObject meteorite4;
    [SerializeField]
    private GameObject spaceJunk1;
    [SerializeField]
    private GameObject spaceJunk2;
    [SerializeField]
    private GameObject spaceJunk3;
    [SerializeField]
    private GameObject spaceJunk4;

    private float maxX = 12.0f;
    private float minY = -4.0f;
    private float maxY = 4.0f;
    private float minimumX = 2.0f;
    private float maximumX = 6.0f;

    private int meteoriteFrequencyWeight = 1;
    private int spaceJunkFrequencyWeight = 3;
    private GameObject[] meteoritePool;
    private GameObject[] spaceJunkPool;

    void Start()
    {
        meteoritePool = new GameObject[] { meteorite1, meteorite2, meteorite3, meteorite4 };
        spaceJunkPool = new GameObject[] { spaceJunk1, spaceJunk2, spaceJunk3, spaceJunk4 };
        InvokeRepeating(nameof(SpawnObject), startTime, timeDelay);
    }

    void Update()
    {
    }

    private void SpawnObject()
    {
        GameObject randomObject = PickRandomObject();
        Vector3 spawnPosition;
        Vector3 randomPosition;
        do
        {
            spawnPosition = new Vector3(transform.position.x + maxX, transform.position.y + Random.Range(minY, maxY), 0);
            randomPosition = new Vector3(transform.position.x + Random.Range(minimumX, maximumX), transform.position.y + Random.Range(minY, maxY), 0);
        }
        while (Physics2D.OverlapCircle(spawnPosition, minSpawnRadius) != null);

        GameObject objectInstance = Instantiate(randomObject, spawnPosition, Quaternion.identity);
        objectInstance.GetComponent<Rigidbody2D>().velocity = Vector2.left * moveSpeed;
        GameObject objectRandom = Instantiate(randomObject, randomPosition, Quaternion.identity);
        objectRandom.GetComponent<Rigidbody2D>().velocity = Vector2.left * moveSpeed;
    }


    /**
        This method picks a random GameObject from either meteoritePool or spaceJunkPool based on their relative weights,
        meteoriteFrequencyWeight and spaceJunkFrequencyWeight.
    */
    private GameObject PickRandomObject()
    {
        int totalWeight = meteoriteFrequencyWeight + spaceJunkFrequencyWeight;
        int randomNumber = UnityEngine.Random.Range(0, totalWeight);

        GameObject[] selectedPool;
        if (randomNumber < meteoriteFrequencyWeight)
        {
            selectedPool = meteoritePool;
        }
        else
        {
            selectedPool = spaceJunkPool;
        }

        int randomIndex = UnityEngine.Random.Range(0, selectedPool.Length);
        GameObject selectedObject = selectedPool[randomIndex];
        return selectedObject;
    }
}
