using UnityEngine;

public class onstart : MonoBehaviour
{
    public Transform whitePole;
    public Transform blackPole;
    private bool randomBool;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        randomBool = (UnityEngine.Random.Range(0f, 1f) > 0.5f);

    }

    // Update is called once per frame
    void Update()
    {
        whitePole = GameObject.FindWithTag("white").transform;
        blackPole = GameObject.FindWithTag("black").transform;
        if (randomBool)
        {
            this.transform.parent = blackPole.transform;
            transform.SetParent(blackPole.transform);
        }
        else
        {
            this.transform.parent = whitePole.transform;
            transform.SetParent(whitePole.transform);

        }
    }
}
