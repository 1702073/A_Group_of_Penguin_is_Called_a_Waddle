using UnityEngine;

public class Drops : MonoBehaviour
{

    OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            switch (DropType)
            {
                case DropType.Health:
                    collision.gameObject.GetComponent<Player_Health>()?.Heal(1);
                    break;
            }
        }
    }
    public enum DropType
    {
        Health = 0,
        Buff = 1
    }
}
