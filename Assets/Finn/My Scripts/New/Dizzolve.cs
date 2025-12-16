using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Dizzolve : MonoBehaviour
{
    public SpriteRenderer EnemySprite;
    public float dizzolveAmount = 0;

    public Color black = Color.black;
    public Color white = Color.white;
    public bool IsTakingDamage = false;
    public float LastHealth;
    public GameObject dissolveVFX;
    public bool cooldown = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Enemy_Health_and_Damage enemyHealth = GetComponent<Enemy_Health_and_Damage>();
        dizzolveAmount = enemyHealth.enemyHealth / 100;
        EnemySprite.material.SetFloat("_Dizzolve", dizzolveAmount * 100);

        PolaritySwitch polarity = GetComponent<PolaritySwitch>();
        if (polarity != null && polarity.Polarity)
        {
            EnemySprite.material.SetColor("_Color", white);
            EnemySprite.material.SetColor("_EdgeColor", black);
        }
        else if (polarity != null)
        {
            EnemySprite.material.SetColor("_Color", black);
            EnemySprite.material.SetColor("_EdgeColor", white);

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
            Debug.Log("Not Taking Damage FUCK YOU");
        }

      

        if (IsTakingDamage)
        {
        dissolveVFX.SetActive(true);
        }
        else
        {
         dissolveVFX.SetActive(false);
        }
    }

}
