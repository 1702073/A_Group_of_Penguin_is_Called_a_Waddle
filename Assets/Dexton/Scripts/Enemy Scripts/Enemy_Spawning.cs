using UnityEngine;
using UnityEngine.Rendering;

public class Enemy_Spawning : MonoBehaviour
{
    public GameObject enemyPrefab;

    private float _randX;
    private float _randY;

    public int enemyCount;

    void Awake()
    {
        //enemyPrefab = Resources.Load<GameObject>("Prefabs/Enemy/Enemy_Basic");
        //SpawnEnemy(enemyCount);
    }

    public void SpawnEnemy(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            _randX = Random.Range(-3f, 3f);
            _randY = Random.Range(-3f, 3f);

            Vector2 variation = new Vector2(_randX, _randY);

            Instantiate(enemyPrefab, transform.position + (Vector3)variation, Quaternion.identity);
        }
    }
}
