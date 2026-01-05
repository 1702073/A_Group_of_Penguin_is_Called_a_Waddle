using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class EntryExplain : MonoBehaviour
{

    public GameObject explainPanel;
    public bool starting;
    public void Awake()
    {
        starting = true;
    }

    private void Start()
    {
        StartCoroutine("StartExplanation");
    }

    void Update()
    {
        //if (starting == true)
        //{
            
        //    StartExplanation();
           
        //}
        
    }
    IEnumerator StartExplanation()
    {
        explainPanel.SetActive(true);
        starting = false;
        yield return new WaitForSeconds(5f); // Display for 5 seconds
        Console.WriteLine("AAAAAAAAAAAA");
        explainPanel.SetActive(false);
    }
}
