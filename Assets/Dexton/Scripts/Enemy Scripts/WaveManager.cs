using UnityEngine;
using System.Linq;

public class WaveManager : MonoBehaviour
{

    private int _WaveNumber = 0;
    private int _enemiesAlive;
    private GameObject[] _enemySpawners;

    public void Start()
    {
        _enemySpawners = GameObject.FindGameObjectsWithTag("EnemySpawner");
    }

    private void Update()
    {
        _enemiesAlive = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (_enemiesAlive == 0)
        {
            NextWave();
        }
    }
    private void NextWave()
    {
        _WaveNumber++;

        foreach (var spawner in _enemySpawners)
        {
            Enemy_Spawning Enemy_Spawning = spawner.GetComponent<Enemy_Spawning>();
            Enemy_Spawning.SpawnEnemy(Enemy_Spawning.enemyCount);
            Enemy_Spawning.enemyCount *= 2; // Increase enemy count for next wave
        }
    }
}
