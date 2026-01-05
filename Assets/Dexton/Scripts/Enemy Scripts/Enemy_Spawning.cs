using UnityEngine;
using UnityEngine.Rendering;

public class Enemy_Spawning : MonoBehaviour
{
    public GameObject enemyPrefab0;
    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;
    public GameObject enemyPrefab4;
    private float _randX;
    private float _randY;
    public float randomBool; 
    public int enemyCount;

    public void Update()
    {
       
        enemyPrefab0.GetComponent<Renderer>().shadowCastingMode = ShadowCastingMode.On;
        enemyPrefab0.GetComponent<Renderer>().receiveShadows = true;
        enemyPrefab0.GetComponent<Renderer>().motionVectorGenerationMode = MotionVectorGenerationMode.Object;


    }
    void Awake()
    {
        randomBool = (UnityEngine.Random.Range(1, 4));
        //enemyPrefab = Resources.Load<GameObject>("Prefabs/Enemy/Enemy_Basic");
        //SpawnEnemy(enemyCount);
    }

    public void SpawnEnemy(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            randomBool = (UnityEngine.Random.Range(1, 4));
            if (randomBool == 1)
            {
                enemyPrefab0 = enemyPrefab1;
            }
            else if (randomBool == 2)
            {
                enemyPrefab0 = enemyPrefab2;
            }
            else if (randomBool == 3)
            {
                enemyPrefab0 = enemyPrefab3;
            }
            else if (randomBool == 4)
            {
                enemyPrefab0 = enemyPrefab4;
            }

            _randX = Random.Range(-3f, 3f);
            _randY = Random.Range(-3f, 3f);

            Vector2 variation = new Vector2(_randX, _randY);

            Instantiate(enemyPrefab0, transform.position + (Vector3)variation, Quaternion.identity);
        }
    }
}
