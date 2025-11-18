using UnityEngine;

public class FullCombat : MonoBehaviour
{
    public bool SwordEquipped;
    public bool bowEquipped;
    public bool Bow1Equipped;
    public Animator animator;
    public GameObject ArrowPrefab;
    public Transform firePoint;
    public GameObject Sword;
    public GameObject Bow;
    public GameObject Bow1;//drawn bow
    public float ArrowSpeed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void SwordMethod()
    {
        Debug.Log("Got Sword");
        SwordEquipped = true;
        bowEquipped = false;
        Bow1Equipped = false;
        Sword.SetActive(SwordEquipped);
    }
    public void BowMethod()
    {
        Debug.Log("Got Bow");
        SwordEquipped = false;
        bowEquipped = true;
        Bow1Equipped = false;
        Bow.SetActive(bowEquipped);
    }
    // Update is called once per frame
    void Update()
    {
        Sword.SetActive(SwordEquipped);
        Bow.SetActive(bowEquipped);

        if (SwordEquipped == true & Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.Play("sword");
            // Attack with sword
        }
        if (bowEquipped == true & Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.Play("Bow");
            // Instantiate the projectile prefab at the fire point's position and rotation
            GameObject projectile = Instantiate(ArrowPrefab, firePoint.position, firePoint.rotation);

            // Get the Rigidbody2D component of the instantiated projectile
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            ArrowPrefab.GetComponent<Rigidbody2D>().linearVelocity = transform.right * ArrowSpeed;
            // Attack with bow
        }


    }
    public void Enable()
    {
        Bow1.SetActive(true);
    }

    public void Disable()
    {
        Bow1.SetActive(false);

    }
}
