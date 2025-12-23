using UnityEngine;

public class PolarityCollider : MonoBehaviour
{
    Collider2D col2D;
    Collider col3D;
    bool lastPolarity;
    
    void Start()
    {
        col2D = GetComponent<Collider2D>();
        col3D = GetComponent<Collider>();
        if (PolarityManager.Instance != null)
        {
            lastPolarity = PolarityManager.Instance.IsWhitePolarity;
        }
        UpdateCollider();
    }
    
    void Update()
    {
        if (PolarityManager.Instance != null && PolarityManager.Instance.IsWhitePolarity != lastPolarity)
        {
            lastPolarity = PolarityManager.Instance.IsWhitePolarity;
            UpdateCollider();
        }
    }
    
    void UpdateCollider()
    {
        if (PolarityManager.Instance == null) return;
        
        bool shouldDisable = false;
        
        if (gameObject.CompareTag("whitec") && PolarityManager.Instance.IsWhitePolarity)
        {
            shouldDisable = true;
        }
        else if (gameObject.CompareTag("blackc") && !PolarityManager.Instance.IsWhitePolarity)
        {
            shouldDisable = true;
        }
        
        if (col2D != null) col2D.enabled = !shouldDisable;
        if (col3D != null) col3D.enabled = !shouldDisable;
    }
}
