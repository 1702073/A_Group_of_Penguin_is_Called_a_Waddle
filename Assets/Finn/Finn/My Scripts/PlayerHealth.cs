using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Timeline;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public float Phealth = 10;
    public GameObject slider;
    public GameObject deathScreen;
    void Update()
    {
        slider.GetComponent<UnityEngine.UI.Slider>().value = Phealth;
        if (Phealth <= 0)
        {
            Die();
        }
    }
    public void heal()
    {
        Phealth = 10;
    }
    public void Die()
    {
        deathScreen.SetActive(true);
    }
}






