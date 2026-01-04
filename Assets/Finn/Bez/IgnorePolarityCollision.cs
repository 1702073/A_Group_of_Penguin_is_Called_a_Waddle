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
        
        GameObject[] allObjects = FindObjectsByType<GameObject>(FindObjectsSortMode.None);
        foreach (GameObject obj in allObjects)
        {
            if (obj.CompareTag("white") || obj.CompareTag("black"))
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
