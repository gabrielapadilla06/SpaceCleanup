using System.Collections;
using Constants;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 7f;
    public float min_Y, max_Y;
    public float min_X, max_X;

    [SerializeField]
    public Slider healthSlider;    

    [SerializeField]
    public GameObject endDialog;

    [SerializeField]
    public GameObject gameoverDialog;

     [SerializeField]
    public GameObject quizDialog;


    [SerializeField]
    public GameObject scoreManager;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    private GameObject player_Bullet;

    [SerializeField]
    private Transform attack_Point1;

    [SerializeField]
    private Transform attack_Point2;

    public float attack_Timer = 0.35f;
    private float current_Attack_Timer;

    public int maxHealth = 15;
    public int damage = 1; // Amount oƒ damage received
    
    public int life = 1;
    private int currentHealth;
    private bool isBlinking = false;

    // Start is called before the first frame update
    void Start()
    {
        current_Attack_Timer = attack_Timer;
        currentHealth = maxHealth;

        // Initialize health bar
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;

        endDialog.SetActive(false);
        gameoverDialog.SetActive(false);
        quizDialog.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        // Spaceship should not be affected by collisions when blinking
        if (isBlinking)
        {
            return;
        }
        GameObject hitObject = hitInfo.gameObject;
        if (hitObject.layer == (int)GameLayer.Satellite || hitObject.layer == (int)GameLayer.Meteorite)
        {
            hitObject.GetComponent<SpaceObjectController>().TakeDamage();
            Destroy(hitObject);
            
            var hasPlayerDied = TakeDamage();
            if (hasPlayerDied) {
                // TODO: Display game over dialog
                Time.timeScale = 0f;
                endDialog.SetActive(true);
                Destroy(gameObject);
                return;
            }

            if (!isBlinking)
            {
                isBlinking = true;
                StartCoroutine(Blink());
            }
        }
        //PowerUp collision
        else if (hitObject.layer == (int)GameLayer.Powerup)
        {
            currentHealth += life;
            healthSlider.value = currentHealth;
            Destroy(hitObject);
            Debug.Log(currentHealth);
        }
    }

    private void MovePlayer()
    {
        if (Input.GetAxisRaw("Vertical") > 0f)
        {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;
            if (temp.y > max_Y)
                temp.y = max_Y;
            transform.position = temp;
        }
        else if (Input.GetAxisRaw("Vertical") < 0f)
        {
            Vector3 temp = transform.position;
            temp.y -= speed * Time.deltaTime;
            if (temp.y < min_Y)
                temp.y = min_Y;
            transform.position = temp;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;
            if (temp.x > max_X)
                temp.x = max_X;
            transform.position = temp;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;
            if (temp.x < min_X)
                temp.x = min_X;
            transform.position = temp;
        }
    }
    private void Attack()
    {
        attack_Timer += Time.deltaTime;
        var canAttack = attack_Timer > current_Attack_Timer;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canAttack)
            {
                attack_Timer = 0f;
                var scoreController = scoreManager.GetComponent<ScoreController>();
                var bullet1 = Instantiate(player_Bullet, attack_Point1.position, Quaternion.identity);
                bullet1.GetComponent<BulletController>().scoreController = scoreController;
                var bullet2 = Instantiate(player_Bullet, attack_Point2.position, Quaternion.identity);
                bullet2.GetComponent<BulletController>().scoreController = scoreController;
            }

        }
    }

    private IEnumerator Blink()
    {
        for (int i = 0; i < 10; i++)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;
            yield return new WaitForSeconds(0.1f);
        }

        isBlinking = false;
        spriteRenderer.enabled = true;
    }

    private bool TakeDamage()
    {
        currentHealth -= damage;
        Debug.Log(currentHealth);
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        healthSlider.value = currentHealth;

        if (currentHealth == 0)
        {
            return true;
        }

        return false;
    }
}
