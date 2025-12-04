using UnityEngine;

public class Enemy_Health_and_Damage : MonoBehaviour
{
    public int enemyDamage= 1;
    public int enemyHealth = 3;

    public void Damage(int damageAmount)
    {
        enemyHealth -= damageAmount;
        Debug.Log("enemy took damage");
        if (enemyHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(this.gameObject);

        Debug.Log($"{gameObject.name} died");
    }


}
