
using UnityEngine;

public class WaveSystem2D : MonoBehaviour
{
    

   
    public float waveNumber = 1;
    public float enemiesToSpawn = 5;
    public float EnemiesAlive = 0;
    public bool waveInProgress = false;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public Transform spawn4;
    public Transform spawn5;
    public GameObject EnemyDefault;
    public bool wavesTurnedOn = false;
    public int RandomNumber;
    public System.Random random = new System.Random();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int randomNumber = random.Next(1, 6);
    }
    
    // Update is called once per frame
    void Update()
    {
         
       if (wavesTurnedOn == true && waveInProgress == false)
        { 
                newwave();
            
        }
       if (EnemiesAlive <= 0 && wavesTurnedOn == true)
        {
            waveInProgress = false;
            waveNumber += 1;
            
        }
    }

    void newwave()
    {
        waveInProgress = true;
        EnemiesAlive = enemiesToSpawn;
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            wave();

            



        }
        void wave()
        {
            RandomNumber = random.Next(1, 5);
            if (RandomNumber == 1)
            {
                GameObject gameObjecte = Instantiate(EnemyDefault, spawn1.position * RandomNumber, spawn1.rotation);
                Rigidbody2D rb = gameObjecte.GetComponent<Rigidbody2D>();
                EnemyDefault.GetComponent<Rigidbody2D>();
                
            }
            if (RandomNumber == 2)
            {
                GameObject gameObjecte = Instantiate(EnemyDefault, spawn2.position, spawn2.rotation);
            }
            if (RandomNumber == 3)
            {
                GameObject gameObjecte = Instantiate(EnemyDefault, spawn3.position, spawn3.rotation);
            }
            if (RandomNumber == 4)
            {
                GameObject gameObjecte = Instantiate(EnemyDefault, spawn4.position, spawn4.rotation);
            }
            if (RandomNumber == 5)
            {
                GameObject gameObjecte = Instantiate(EnemyDefault, spawn5.position, spawn5.rotation);
            }
        }
    }
}
