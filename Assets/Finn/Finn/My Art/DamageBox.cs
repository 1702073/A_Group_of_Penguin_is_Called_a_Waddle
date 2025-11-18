using UnityEngine;

public class DamageBox : MonoBehaviour
{
 
     private bool isAttacking = false;
   
     private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if enemyhealth component
        EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemyHealth != null && isAttacking == false)
        {
           
            Debug.Log("Collided with enemy");
            isAttacking = true;
            collision.gameObject.GetComponent<EnemyHealth>().Ehealth -= 3;
            //enemyHealth.Ehealth -= 3;
            Debug.Log("Enemy health reduced by 3");
            
            
        }
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        // Reset attack
        if (collision.gameObject.GetComponent<EnemyHealth>() != null)
        {
            collision.gameObject.GetComponent<EnemyHealth>().Ehealth -= 3;
            isAttacking = false;
            
        }
        
    }
}