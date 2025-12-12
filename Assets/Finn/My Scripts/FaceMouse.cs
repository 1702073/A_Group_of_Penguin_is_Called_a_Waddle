using UnityEngine;

public class FaceMouse : MonoBehaviour
{
    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        // Get mouse pos
        Vector3 mouseWorldPos = cam.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0f; // ensure no depth offset in 2D

        // Direction from object to the mous
        Vector3 direction = (mouseWorldPos - transform.position).normalized;

        // Calculate angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply rotation (offset so right = 0° by default)
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
