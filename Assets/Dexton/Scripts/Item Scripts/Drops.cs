using UnityEngine;

public class Drops : MonoBehaviour
{
    /*
    OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            switch (DropType)
            {
                case DropType.Health:
                    collision.gameObject.GetComponent<Player_Health>()?.Heal(1);
                break;
                case DropType.Speed;
                    collision.gameObject.GetComponent<Player_Movement>()?.ddddddddddddddddddddd();
                break;
                case DropType.Damage:
                    collision.gameObject.GetComponent<Player_Buff>()?.ApplyBuff();
                break;
                case DropType.Buff:
                    collision.gameObject.GetComponent<Player_Buff>()?.ApplyBuff();
                break;
            }
        }
    }
    */
    public enum DropType
    {
        Health = 0,
        Speed = 1,
        Damage = 2,
        Buff = 3
    }
}
