using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy_Health_and_Damage), typeof(Enemy_Movement))] // Enemy Scripts

public class Enemy_Drops : MonoBehaviour
{ // Put on Enemy

    public List<Item> gameObjects;

    public void Drop_Item()
    {
        Console.WriteLine("Dropping Item");

        Instantiate(gameObjects[UnityEngine.Random.Range(0, gameObjects.Count)], transform.position, Quaternion.identity);
    }
}
