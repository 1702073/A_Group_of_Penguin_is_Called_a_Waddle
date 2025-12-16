using UnityEngine;

public class PolarityObject : MonoBehaviour
{
    SpriteRenderer sr;
    
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        UpdateColor();
    }
    
    void Update()
    {
        UpdateColor();
    }
    
    void UpdateColor()
    {
        if (sr != null && PolarityManager.Instance != null)
        {
            Color targetColor = PolarityManager.Instance.GetCurrentColor();
            sr.material.SetColor("_Color", targetColor);
        }
    }
}
