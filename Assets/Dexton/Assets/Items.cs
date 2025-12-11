using UnityEngine;

[CreateAssetMenu(fileName = "Items", menuName = "Scriptable Objects/Items")]

public class Item : ScriptableObject
{
    [Header("Only Gamplay")]
    public ItemType type;
    public ActionType actionType;
    public Vector2Int range = new Vector2Int(5, 4);
}

public enum ItemType
{
    None,
    Weapon,
    Tool,
    Consumable,
    Miscellaneous
}

public enum ActionType
{
    None,
    Place,
    Remove,
    Use
}