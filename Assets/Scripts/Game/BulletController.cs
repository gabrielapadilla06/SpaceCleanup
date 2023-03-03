using Constants;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 7.0f;
    public float maxLifetime = 5.0f; // In seconds

    [HideInInspector]
    public ScoreController scoreController;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, maxLifetime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        GameObject hitObject = hitInfo.gameObject;
        if (hitObject.layer == (int)GameLayer.Satellite)
        {
            var hitObjectController = hitObject.GetComponent<SpaceObjectController>();
            var isDestroyed = hitObjectController.TakeDamage();
            if (isDestroyed)
            {
                scoreController.AddPoints(hitObjectController.damagePoints);
            }
            Destroy(gameObject);
        }

        if (hitObject.layer == (int)GameLayer.Meteorite)
        {
            Destroy(gameObject);
        }
    }

    private void Move()
    {
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
    }
}

