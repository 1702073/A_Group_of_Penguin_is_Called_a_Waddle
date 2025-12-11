using UnityEngine;
using UnityEngine.Rendering;

public class Enemy_Spawning : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemyCount;
    private float _randX;
    private float _randY;
    private bool black = false;
    private Transform Black;
    private Transform White;

    void Awake()
    {
        //enemyPrefab = Resources.Load<GameObject>("Prefabs/Enemy/Enemy_Basic");
        //SpawnEnemy(enemyCount);
        Black = GameObject.Find("Black").transform;
        White = GameObject.Find("White").transform;
    }

    public void SpawnEnemy(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            _randX = Random.Range(-3f, 3f);
            _randY = Random.Range(-3f, 3f);

            Vector2 variation = new Vector2(_randX, _randY);
            
            
            
            if (black == true)
            {
                var newEnemy = Instantiate(enemyPrefab, Black);
                newEnemy.transform.localPosition += new Vector3(variation.x, variation.y, 0);

                black = false;
            }
            else
            {
                var newEnemy = Instantiate(enemyPrefab, White);
                newEnemy.transform.localPosition += new Vector3(variation.x, variation.y, 0);


                black = true;
            }
        }
    }
}
