using UnityEngine;
using UnityEngine.UI;

public class PolarityObject : MonoBehaviour
{
    SpriteRenderer sr;
    Image img;
    bool lastPolarity;

    void Start()
    {
        img = GetComponent<Image>();
        sr = GetComponent<SpriteRenderer>();
        if (PolarityManager.Instance != null)
        {
            lastPolarity = PolarityManager.Instance.IsWhitePolarity;
        }
        UpdateColor();
    }
   
    void Update()
    {
        UpdateColor();
        CheckPolarityChange();
    }
    
    void UpdateColor()
    {
        if (sr != null && PolarityManager.Instance != null)
        {
            Color targetColor = PolarityManager.Instance.GetCurrentColor();
            sr.material.SetColor("_Color", targetColor);
            if (img != null) img.material.SetColor("_Color", targetColor);
        }
    }
    
    void CheckPolarityChange()
    {
        if (PolarityManager.Instance != null && PolarityManager.Instance.IsWhitePolarity != lastPolarity)
        {
            lastPolarity = PolarityManager.Instance.IsWhitePolarity;
            SpawnVFX();
        }
    }
    
    void SpawnVFX()
    {
        if (PolarityManager.Instance != null && PolarityManager.Instance.polaritySwitchVFX != null)
        {
            Vector3 spawnPos = transform.position;
            GameObject vfx = Instantiate(PolarityManager.Instance.polaritySwitchVFX, spawnPos, Quaternion.identity);
            Destroy(vfx, 2f);
        }
    }
}
