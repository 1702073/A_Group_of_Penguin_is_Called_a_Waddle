using NUnit.Framework;
using UnityEngine;

public class ButtontoKillallEnemies : MonoBehaviour
{
    public KeyCode deathToAll = KeyCode.K;
    private GameObject[] _enemiesAlive;
    Enemy_Health_and_Damage enemy_Health_and_Damage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _enemiesAlive = GameObject.FindGameObjectsWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(deathToAll))
        {
            _enemiesAlive = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (var enemy in _enemiesAlive)
            {
                enemy_Health_and_Damage = enemy.GetComponent<Enemy_Health_and_Damage>();
                enemy_Health_and_Damage.Damage(99999999);
            }
        }
    }
}
