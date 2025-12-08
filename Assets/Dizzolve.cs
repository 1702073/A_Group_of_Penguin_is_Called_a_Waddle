using UnityEngine;

public class Dizzolve : MonoBehaviour
{
    public Material material;
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
        material.SetFloat("_DissolveAmount", 1 - dizzolveAmount);
        // renderer.material.SetColor("_Color", black);
    }
}
