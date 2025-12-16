using UnityEngine;

[RequireComponent(typeof(Collider2D))]

public class Drops : MonoBehaviour
{
    public DropType dropType;
    public GameObject self;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            switch (dropType)
            {
                case DropType.Health:
                    collision.gameObject.GetComponent<Player_Health>()?.Heal(1);
                break;
                case DropType.Speed:
                    collision.gameObject.GetComponent<Player_Movement>()?.SpeedUp(0.5f);
                break;
                case DropType.Damage:
                    collision.gameObject.GetComponent<Player_Attack>()?.AttackUp(0.1f);
                break;
                case DropType.Buff:
                //    collision.gameObject.GetComponent<Player_Buff>()?.ApplyBuff();
                break;
            }
            Destroy(self);

        }
    }
    public enum DropType
    {
        Health = 0,
        Speed = 1,
        Damage = 2,
        Buff = 3
    }
}
