using UnityEngine;

public class Player_Attack : MonoBehaviour
{
    public float playerDamage = 1f;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            var enemy = collision.gameObject.GetComponent<Enemy_Health_and_Damage>();

            if (enemy != null)
            {
                enemy.Damage(playerDamage);
            }
            else
            {
                Debug.LogWarning($"Enemy_Health_and_Damage component not found on {collision.gameObject.name}. No damage applied.");
            }
        }
    }

    //private void OnTriggerStay2D(Collision2D collision)
    //{
    //    if (collision.collider.CompareTag("Enemy"))
    //    {
    //        var enemy = collision.gameObject.GetComponent<Enemy_Health_and_Damage>();
    //        if (enemy != null)
    //        {
    //            enemy.Damage(playerDamage);
    //        }
    //        else
    //        {
    //            Debug.LogWarning($"Enemy_Health_and_Damage component not found on {collision.gameObject.name}. No damage applied.");
    //        }
    //    }
    //}
}
