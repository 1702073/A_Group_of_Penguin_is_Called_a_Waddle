using UnityEngine;

public class ButtontoKillallEnemies : MonoBehaviour
{
    public KeyCode deathToAll = KeyCode.K;
    private GameObject[] _enemiesAlive;
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
                Destroy(enemy);
            }
        }
    }
}
