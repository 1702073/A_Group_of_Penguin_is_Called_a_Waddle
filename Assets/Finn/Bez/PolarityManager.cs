using UnityEngine;
using UnityEngine.UI;

public class PolarityManager : MonoBehaviour
{
    public static PolarityManager Instance;
    
    public bool IsWhitePolarity = false;
    public float cooldownDuration = 3f;
    public Camera mainCamera;
    public RectTransform cooldownBar;
    public GameObject polaritySwitchVFX;

    public float cooldownTimer = 0f;
    public bool onCooldown = false;
    Vector2 originalBarSize;
    
    Color blackBG = Color.black;
    Color whiteBG = Color.white;
    Color whiteSprite = Color.white;
    Color blackSprite = Color.black;
    
    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }
    
    void Start()
    {
        if (mainCamera == null) mainCamera = Camera.main;
        ApplyPolarity();
        if (cooldownBar != null)
        {
            originalBarSize = cooldownBar.sizeDelta;
        }
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !onCooldown)
        {
            SwitchPolarity();
        }
        
        if (onCooldown)
        {
            cooldownTimer -= Time.deltaTime;
            if (cooldownBar != null)
            {
                float fillPercent = 1f - (cooldownTimer / cooldownDuration);
                cooldownBar.sizeDelta = new Vector2(originalBarSize.x * fillPercent, originalBarSize.y);
            }
            
            if (cooldownTimer <= 0f)
            {
                onCooldown = false;
                cooldownTimer = 0f;
                if (cooldownBar != null)
                {
                    cooldownBar.sizeDelta = originalBarSize;
                }
            }
        }
    }
    
    public void SwitchPolarity()
    {
        IsWhitePolarity = !IsWhitePolarity;
        ApplyPolarity();
        onCooldown = true;
        cooldownTimer = cooldownDuration;
        if (cooldownBar != null)
        {
            cooldownBar.sizeDelta = new Vector2(0f, originalBarSize.y);
        }
    }
    
    void ApplyPolarity()
    {
        if (mainCamera != null)
        {
            mainCamera.backgroundColor = IsWhitePolarity ? whiteBG : blackBG;
        }
        
        GameObject[] allObjects = FindObjectsByType<GameObject>(FindObjectsSortMode.None);
        foreach (GameObject obj in allObjects)
        {
            SpriteRenderer sr = obj.GetComponent<SpriteRenderer>();
            if (sr != null && obj.CompareTag("Player") || obj.CompareTag("Enemy") || obj.CompareTag("notplayer"))
            {
                Color targetColor = IsWhitePolarity ? blackSprite : whiteSprite;
                sr.material.SetColor("_Color", targetColor);
            }
        }
    }
    
    public Color GetCurrentColor()
    {
        return IsWhitePolarity ? blackSprite : whiteSprite;
    }
}
