using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(Enemy_Health_and_Damage), typeof(Enemy_Movement))] // Enemy Scripts

public class Enemy_Drops : MonoBehaviour
{ // Put on Enemy

    public List<Tuple<GameObject,int>> gameObjects;

    public void Drop_Item()
    {
        Console.WriteLine("Dropping Item");
        var weights = gameObjects.ConvertAll(tuple => {
            var item = tuple.Item1;
            var weight = tuple.Item2;

            return new List<Item>(new Item[weight]).ConvertAll(_ => item);
        }).SelectMany(x => x).ToList();

        Instantiate(weights[UnityEngine.Random.Range(0, weights.Count)], transform.position, Quaternion.identity);
    }
}
