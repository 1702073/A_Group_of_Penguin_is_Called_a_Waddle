using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    PlayerHealth playerHealth;
    public bool isDead = false;
    public float Ehealth = 10;
    public GameObject me;
    public bool isAttacking = false;
    public GameObject player;
    public GameObject Me1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Ehealth = 10;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(gameObject.name);
        // Check if the collided GameObject has the desired tag
        if (collision.gameObject.CompareTag("Player") && isAttacking == false)
        {
            Debug.Log("Collided with player part 2");
            isAttacking = true;


            PlayerHealth playerHealth = FindFirstObjectByType<PlayerHealth>();
            playerHealth.Phealth -= 3;
            Debug.Log("Player health reduced by 3");
        }

        

    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the collided GameObject has the desired tag
        if (collision.gameObject.CompareTag("Player"))
        {
            isAttacking = false;
        }
    }

    private void Update()
    {
        if (Ehealth <= 0)
        { 
            isDead = true;
            player.gameObject.GetComponentInChildren<WaveSystem2D>().EnemiesAlive -= 1;
            Ehealth = 10;
            Destroy(Me1);
          
        }

        
        if (isDead)
        {
           player.gameObject.GetComponentInChildren<WaveSystem2D>().EnemiesAlive -= 1;
           Destroy(me);
           Destroy(gameObject);
        }
    }
}
