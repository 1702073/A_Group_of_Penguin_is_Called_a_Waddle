using UnityEngine;

[RequireComponent(typeof(Enemy_Movement), typeof(Enemy_Drops))] // Enemy Scripts

public class Enemy_Health_and_Damage : MonoBehaviour
{
    public int enemyDamage= 1;
    public float enemyHealth = 3f;

    Enemy_Drops enemy_Drops;


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

        enemy_Drops.Drop_Item();

        Debug.Log($"{gameObject.name} died");
    }
}
