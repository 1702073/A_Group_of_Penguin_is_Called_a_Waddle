using UnityEngine;

public class Enemy_Health_and_Damage : MonoBehaviour
{
    public int enemyDamage= 1;
    public float enemyHealth = 3f;

    public void Damage(float damageAmount)
    {
        enemyHealth -= damageAmount;
        Debug.Log("enemy took damage");

        if (enemyHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(this.gameObject);

        Debug.Log($"{gameObject.name} died");
    }


}
