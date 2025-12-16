using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PolarityUI : MonoBehaviour
{
    

    public GameObject polarizedManager;
    public float cooldownDuration = 3f;

    float cooldownTimer = 0f;
    bool onCooldown = false;

    public Image offCooldowm;
    public Image halfCooldown;
    public Image partialCooldown;
    public Image fullCooldown;
    PolarityManager polarityManager;
    void Start()
    {
        polarityManager = playerPrefab.GetComponent<Player_Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onCooldown)
        {
            cooldownTimer -= Time.deltaTime;

            if (cooldownTimer == 3f)
            {
                offCooldowm.enabled = false;
                halfCooldown.enabled = false;
                partialCooldown.enabled = false;
                fullCooldown.enabled = true;

            }

            if (cooldownTimer == 2f)
            {
                offCooldowm.enabled = false;
                halfCooldown.enabled = false;
                partialCooldown.enabled = true;
                fullCooldown.enabled = false;
            }
            if (cooldownTimer == 1f)
            {
                offCooldowm.enabled = false;
                halfCooldown.enabled = true;
                partialCooldown.enabled = false;
                fullCooldown.enabled = false;
            }

            if (cooldownTimer <= 0f)
            {
                offCooldowm.enabled = true;
                halfCooldown.enabled = false;
                partialCooldown.enabled = false;
                fullCooldown.enabled = false;
            }
        }
    }
}
