using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider2D))]
public class Player_Health_and_Damage : MonoBehaviour
{
    [SerializeField] private int _defaultHealth = 3;
    [SerializeField] private int _defaultLives = 1;
    public int playerHealth;
    public int playerLives;
    [SerializeField] private int _deathSceneNum;

    private void Start()
    {
        playerHealth = _defaultHealth;
        playerLives = _defaultLives;
    }

    void Die()
    {
        if(playerLives <= 0)
        {
            Debug.Log("player is out of Lives");
            SceneManager.LoadScene(_deathSceneNum);
        }
        else
        {
            playerLives--;
            playerHealth = 3; // Reset health for the new life || remeber to change this value if you change the starting health
        }
        Debug.Log("player died");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            playerHealth--;
            Debug.Log("player took damage");

            if (playerHealth <= 0)
            {
                Die();
            }
        }
    }
}
