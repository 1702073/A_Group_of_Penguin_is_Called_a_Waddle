using UnityEngine;

public class GetSword : MonoBehaviour
{
    public void RunAction()
    {
        Debug.Log("Got Sword");
        GetComponent<FullCombat>().SwordEquipped = true;
        GetComponent<FullCombat>().bowEquipped = false;
        GetComponent<FullCombat>().Bow1Equipped = false;
    }
}
