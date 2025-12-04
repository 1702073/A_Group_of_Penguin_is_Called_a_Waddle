using UnityEngine;

public class Player_Attack : MonoBehaviour
{
    public float playerDamage = 1f;




    private void Start()
    {



    }


    private void OnCollision2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            var enemyHealth = collision.gameObject.GetComponent<Enemy_Health_and_Damage>();
            if (enemyHealth != null)
            {
               // enemyHealth.Damage(Mathf.RoundToInt(playerDamage));
            }
            else
            {
                Debug.LogWarning($"Enemy_Health_and_Damage component not found on {collision.gameObject.name}. No damage applied.");
            }
        }
    }
}
