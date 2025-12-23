using System;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Dizzolve : MonoBehaviour
{
    public SpriteRenderer EnemySprite;
    public float dizzolveAmount = 0;
    public float dizzolveAmountb = 0;

    public bool IsTakingDamage = false;
    public float LastHealth;
    public GameObject dissolveVFX;
    public bool cooldown = false;
    public bool switched = false;
    public bool CD = false;
    public Range range;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.parent != null)
        {
            // Use CompareTag for performance optimization over the == operator
            if (transform.parent.CompareTag("white"))
            {
                Debug.Log("The immediate parent has the tag: white");
                switched = false;
            }
            else
            {
                Debug.Log("The immediate parent does not have that tag.");
            }
            // Use CompareTag for performance optimization over the == operator
            if (transform.parent.CompareTag("black"))
            {
                Debug.Log("The immediate parent has the tag: black");
                switched = true;
            }
            else
            {
                Debug.Log("The immediate parent does not have that tag.");
            }
        }
        else
        {
            Debug.Log("The GameObject has no parent.");
        }

        Enemy_Health_and_Damage enemyHealth = GetComponent<Enemy_Health_and_Damage>();
        dizzolveAmount = enemyHealth.enemyHealth / 100;
       

        if (switched == true)
        {
            EnemySprite.material.SetFloat("_Dizzolve", dizzolveAmount * 100);
        }
        else
        {
            EnemySprite.material.SetFloat("_Dizzolve", dizzolveAmount * 100);
        }
        

        PolaritySwitch polarity = GetComponent<PolaritySwitch>();
        if (polarity != null && polarity.Polarity)
        {
            switched = true;
        }
        else if (polarity != null)
        {
            switched = false;

        }

        if (cooldown = false && enemyHealth.enemyHealth != LastHealth)
        {
            IsTakingDamage = true;
            LastHealth = enemyHealth.enemyHealth;
            Debug.Log("Taking Damage");

        }
        else
        {
            IsTakingDamage = false;
            Debug.Log("Not Taking Damage");
        }



        if (CD = true && IsTakingDamage == true)
        {
            dissolveVFX.SetActive(true);
            CD = false;
        }
        else if (IsTakingDamage == false && CD == false)
        {
            dissolveVFX.SetActive(false);
            CD = true;
        }
    

    }

}
