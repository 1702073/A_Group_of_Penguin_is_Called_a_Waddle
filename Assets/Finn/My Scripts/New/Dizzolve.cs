using UnityEngine;

public class Dizzolve : MonoBehaviour
{
    public SpriteRenderer EnemySprite;
    public float dizzolveAmount = 0;

    public Color black = Color.black;
    public Color white = Color.white;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Enemy_Health_and_Damage enemyHealth = GetComponent<Enemy_Health_and_Damage>();
        dizzolveAmount = enemyHealth.enemyHealth / 100;
        EnemySprite.material.SetFloat("_Dizzolve",dizzolveAmount * 100);

        PolaritySwitch polarity = GetComponent<PolaritySwitch>();
        if (polarity == true)
        {
            EnemySprite.material.SetColor("_Color", white);
            EnemySprite.material.SetColor("_EdgeColor", black);
        }
        else
        {
            EnemySprite.material.SetColor("_Color", black);
            EnemySprite.material.SetColor("_EdgeColor", white);

        }
    }
}
