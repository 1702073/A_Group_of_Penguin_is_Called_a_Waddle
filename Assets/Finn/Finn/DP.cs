using TMPro;
using UnityEngine;

public class DP : MonoBehaviour
{
    public TextMeshProUGUI DMG;
    public float dmgNum = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        DMG.text = dmgNum.ToString();
    }
}
