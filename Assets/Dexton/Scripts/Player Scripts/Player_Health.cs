using Unity.Android.Gradle.Manifest;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider2D))]
public class Player_Health : MonoBehaviour
{
    [SerializeField] private int _defaultHealth = 3;
    [SerializeField] private int _defaultLives = 1;
    private string _deathScene = "Death";
    public int playerHealth;
    public int playerLives;

    private void Start()
    {
        playerHealth = _defaultHealth;
        playerLives = _defaultLives;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Add a get component to get the enemy damage then put it in the Damage(1) function
        if (collision.collider.CompareTag("Enemy"))
        {
            Damage(collision.gameObject.GetComponent<Enemy_Health_and_Damage>()?.enemyDamage ?? 1);
            if (!collision.gameObject.GetComponent<Enemy_Health_and_Damage>())
            {
                Debug.LogWarning($"Enemy_Health_and_Damage component not found on {collision.gameObject.name}. Default damage of 1 applied.");
            }
        }
        /*
        if (collision.collider.Item)
        {
            Damage(collision.gameObject.GetComponent<Enemy_Health_and_Damage>()?.enemyDamage ?? 1);
            if (!collision.gameObject.GetComponent<Enemy_Health_and_Damage>())
            {
                Debug.LogWarning($"Enemy_Health_and_Damage component not found on {collision.gameObject.name}. Default damage of 1 applied.");
            }
        }
        */
    }

    public void Heal(int healAmount)
    {
        playerHealth += healAmount;

        Debug.Log("player healed");

        if (playerHealth > _defaultHealth)
        {
            playerHealth = _defaultHealth; // Cap health at default max health
        }
    }

    public void Damage(int damageAmount)
    {
        playerHealth -= damageAmount;

        Debug.Log("player took damage");

        if (playerHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if(playerLives <= 0)
        {
            Debug.Log("player is out of Lives");
            SceneManager.LoadScene(_deathScene);
        }
        else
        {
            playerLives--;
            playerHealth = _defaultHealth; // Reset health for the new life
        }
        Debug.Log("player died");
    }
    public void SavePlayer(Player_Movement player_movement)
    {
        SaveSystem.SavePlayer(this, GetComponent<Player_Movement>());
    }
    public void LoadPlayer(Player_Movement player_movement)
    {

        PlayerData data = SaveSystem.LoadPlayer();
        playerHealth = data.playerHealth;
        playerLives = data.playerLives;
        
        player_movement.moveSpeed = data.moveSpeed;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }

}
