using UnityEngine;
using UnityEngine.Rendering;

public class Enemy_Spawning : MonoBehaviour
{
    GameObject enemyPrefab;


    void Start()
    {
        enemyPrefab = Resources.Load<GameObject>("Prefabs/Enemy/Enemy_Basic");
        //SpawnEnemy();
    }

}
