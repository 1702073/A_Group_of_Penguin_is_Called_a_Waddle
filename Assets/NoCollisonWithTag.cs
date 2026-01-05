using UnityEngine;

public class NoCollisonWithTag : MonoBehaviour
{
    public void Start()
    {
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Detected with " + collision.gameObject.name);
        if (collision.gameObject.tag == "NoCollision")
        {
            Debug.Log("Ignoring Collision with " + collision.gameObject.name);
            Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        
        Physics.IgnoreCollision(GetComponent<Collider>(), collision.gameObject.GetComponent<Collider>());
        }
    }

}
