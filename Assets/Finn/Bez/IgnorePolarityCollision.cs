using UnityEngine;

public class IgnorePolarityCollision : MonoBehaviour
{
    Collider2D myCollider;
    
    void Start()
    {
        myCollider = GetComponent<Collider2D>();
        SetupIgnoreCollisions();
    }
    
    void SetupIgnoreCollisions()
    {
        if (myCollider == null) return;
        
        var allObjects = FindObjectsByType<Transform>(FindObjectsSortMode.None);
        foreach (var obj in allObjects)
        {
            if (obj.CompareTag("whitec") || obj.CompareTag("blackc"))
            {
                Collider2D otherCollider = obj.GetComponent<Collider2D>();
                if (otherCollider != null)
                {
                    Physics2D.IgnoreCollision(myCollider, otherCollider, true);
                }
            }
        }
    }
    
    void OnEnable()
    {
        if (myCollider != null)
        {
            SetupIgnoreCollisions();
        }
    }
}
