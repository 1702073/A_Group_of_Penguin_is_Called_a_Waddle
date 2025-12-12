using UnityEngine;

public class arrow : MonoBehaviour
{
    public float ArrowSpeed = 20f;
    public void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().linearVelocity = transform.right * ArrowSpeed;
    }
}
