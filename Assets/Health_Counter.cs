using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Health_Counter : MonoBehaviour
{

    [Header("Player Prefab")]
    private GameObject playerPrefab;

    [Header("Health States")]
    public Image full, half, low, empty, fulllast, halflast, lowlast, emptylast;
    Player_Health player_Health_and_Damage;
        
    private void Start()
    {
        playerPrefab = GameObject.FindWithTag("Player");
        player_Health_and_Damage = playerPrefab.GetComponent<Player_Health>();
    }

    private void Update()
    {
        SetImage(player_Health_and_Damage.playerHealth, player_Health_and_Damage.playerLives );
    }
    //public void SetMaxHealth(int playerHealth)
    //{
    //    healthSlider.maxValue = playerHealth;
    //    healthSlider.value = playerHealth;


    //}

    //public void SetHealth(int playerHealth)
    //{
    //    healthSlider.value = playerHealth;

    //    fill.color = gradient.Evaluate(healthSlider.normalizedValue);
    //}
    public void SetImage(int playerHealth, int extraPlayerLives)
    {
        if (playerHealth >= 3 && extraPlayerLives >= 1)
        {
            full.enabled = true;
            half.enabled = false;
            low.enabled = false;
            empty.enabled = false;
        }
        else if(playerHealth == 2 && extraPlayerLives >= 1)
        {
            full.enabled = false;
            half.enabled = true;
            low.enabled = false;
            empty.enabled = false;
        }
        else if (playerHealth == 1 && extraPlayerLives <= 1)
        {
            full.enabled = false;
            half.enabled = false;
            low.enabled = true;
            empty.enabled = false;
        }
        else if (playerHealth <= 0 && extraPlayerLives >= 1)
        {
            full.enabled = false;
            half.enabled = false;
            low.enabled = false;
            empty.enabled = true;
        }
        else if (playerHealth >= 3 && extraPlayerLives <= 1)
        {
            full.enabled = true;
            half.enabled = false;
            low.enabled = false;
            empty.enabled = false;
        }
        else if (playerHealth == 2 && extraPlayerLives <= 1)
        {
            full.enabled = false;
            half.enabled = true;
            low.enabled = false;
            empty.enabled = false;
        }
        else if (playerHealth == 1 && extraPlayerLives <= 1)
        {
            full.enabled = false;
            half.enabled = false;
            low.enabled = true;
            empty.enabled = false;
        }
        else if (playerHealth <= 0 && extraPlayerLives <= 1)
        {
            full.enabled = false;
            half.enabled = false;
            low.enabled = false;
            empty.enabled = true;
        }

    }
}

