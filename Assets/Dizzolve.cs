using UnityEngine;

public class Dizzolve : MonoBehaviour
{
    public SpriteRenderer Sprite;
    public float dizzolveAmount = 0;
    
    public Color white = Color.black;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Enemy_Health_and_Damage enemyHealth = GetComponent<Enemy_Health_and_Damage>();
        dizzolveAmount = enemyHealth.enemyHealth / 100;
        Sprite.material.SetFloat("_Dizzolve",dizzolveAmount * 100);
        // renderer.material.SetColor("_Color", black);
    }
}
