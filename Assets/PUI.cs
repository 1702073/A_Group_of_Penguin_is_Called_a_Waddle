using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PUI : MonoBehaviour
{
    public Animator polarizedUI;
    public bool lightMode;
    bool canSwitch;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         canSwitch = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& lightMode == false && canSwitch == true)
        {
          
            StartCoroutine(waitDark());
            
        }
        if (Input.GetKeyDown(KeyCode.Space) && lightMode == true && canSwitch == true )
        {
           
            
           
            StartCoroutine(waitLight());


        }
        else
        {
            Console.WriteLine("No");
        }
    }
    IEnumerator waitDark()
    {
        canSwitch = false;
        polarizedUI.SetTrigger("Change");
        lightMode = false;
        new WaitForSeconds(3f);
        canSwitch = true;
        yield return new WaitForSeconds(3f);
    }
    IEnumerator waitLight()
    {
        canSwitch = false;
        polarizedUI.SetTrigger("Change");
        lightMode = true;
        new WaitForSeconds(3f);
        canSwitch = true;
        yield return new WaitForSeconds(0f);
    }
}
