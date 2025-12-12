using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    Camera cam;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }

    private GameObject GetGameObject()
    {
        return gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseWorldPos = cam.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0f; // ensure no depth offset in 2D

        rb.position = mouseWorldPos; 
    }
}
