using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;


[CreateAssetMenu(menuName = "Scriptable objects/Items")]
public class Item : ScriptableObject
{
    

    [Header("Only gameplay")]
    public ItemType itemType;
    public ActionType actionType; 

    //public Vector2Int range = new Vector2Int(5, 4);



    [Header("Only UI")]
    public bool stackable;
    //public int maxStack = 20;

    [Header("Both")]
    public Sprite image;


    public enum ItemType
    {
        None,
        Weapon,
        Tool,
        Consumable,
        Buff, 
        Health
    }

    public enum ActionType
    {
        None,
        Place,
        Remove,
        Use
    }
}


