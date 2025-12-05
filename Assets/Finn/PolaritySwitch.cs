using Unity.VisualScripting;
using UnityEngine;
using System.Collections;

public class PolaritySwitch : MonoBehaviour
{
    // Public inspector fields
    public bool Polarity = false;
    public bool Cooldown = false;
    public float CooldownTime = 1.0f;
    public Animator animator;
    //  timer to track remaining cooldown
    private float cooldownTimer = 0f;
    
    public void Update()
    {
        // Start polarity switch if space pressed and not on cooldown
        if (Input.GetKeyDown(KeyCode.Space) && Cooldown == false)
        {
            SwitchPolarity();
            Cooldown = true;
            cooldownTimer = CooldownTime;
            animator.SetTrigger("SwitchPolarity");
            if (Polarity == true)
            {
                Debug.Log("Switched to Positive Polarity");
                animator.SetBool("PoleSwitch" , true);
            }
            else if (Polarity == false) 
            {
                animator.SetBool("PoleSwitch", false);
                Debug.Log("Switched to Negative Polarity");
            }
        }

        if (Cooldown)
        {   
            cooldownTimer -= Time.deltaTime;
            if (cooldownTimer <= 0f)
            {
                cooldownTimer = 0f;
                Cooldown = false;
            }
        }
    }

    public void SwitchPolarity()
    {
        Polarity = !Polarity;

    }
     

}
