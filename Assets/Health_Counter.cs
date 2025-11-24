using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Health_Counter : MonoBehaviour
{


   public Slider healthSlider;
    public Gradient gradient;
    public Image fill;
    public Image full, half,low, empty;



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
    public void SetImage(int playerHealth)
    {
        if(playerHealth >= 3)
        {
            full.enabled = true;
            half.enabled = false;
            low.enabled = false;
            empty.enabled = false;
        }
        else if(playerHealth == 2)
        {
            full.enabled = false;
            half.enabled = true;
            low.enabled = false;
            empty.enabled = false;
        }
        else if (playerHealth == 1)
        {
            full.enabled = false;
            half.enabled = false;
            low.enabled = true;
            empty.enabled = false;
        }
        else if (playerHealth <= 0)
        {
            full.enabled = false;
            half.enabled = false;
            low.enabled = false;
            empty.enabled = true;
        }
    }
}

