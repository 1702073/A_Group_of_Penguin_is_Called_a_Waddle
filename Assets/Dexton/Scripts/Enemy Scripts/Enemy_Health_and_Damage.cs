using UnityEngine;

[RequireComponent(typeof(Enemy_Movement), typeof(Enemy_Drops))] // Enemy Scripts

public class Enemy_Health_and_Damage : MonoBehaviour
{
    public bool istakingDamage = false;
    public float lasthealth;
    public int enemyDamage= 1;
    public float enemyHealth = 3f;
    public GameObject deathVFX;
    Enemy_Drops enemy_Drops;

    public void Awake()
    {
        enemy_Drops = GetComponent<Enemy_Drops>();
    }
    public void Damage(float damageAmount)
    {
        enemyHealth -= damageAmount;
        Debug.Log("enemy took damage");
     
        if (enemyHealth <= 0)
        {
            Die();
        }
    }
    public void Update()
    {
        if (istakingDamage == false && enemyHealth != lasthealth)
        {
            istakingDamage = true;
            lasthealth = enemyHealth;
            Debug.Log("Taking Damage");
        }
        else
        {
            istakingDamage = false;
            Debug.Log("Not Taking Damage");
        }
        

        if (istakingDamage == true)
        {
            deathVFX.SetActive(true);
        }
        else
        {
            deathVFX.SetActive(false);
        }
    }

    public void Die()
    {
        Destroy(this.gameObject);

        enemy_Drops.Drop_Item();

        Debug.Log($"{gameObject.name} died");
    }
}
