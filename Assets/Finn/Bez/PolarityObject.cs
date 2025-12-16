using UnityEngine;
using UnityEngine.UI;
public class PolarityObject : MonoBehaviour
{
    SpriteRenderer sr;
    Image img;

    void Start()
    {
        img = GetComponent<Image>();
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
            img.material.SetColor("_Color", targetColor);
        }
    }
}
