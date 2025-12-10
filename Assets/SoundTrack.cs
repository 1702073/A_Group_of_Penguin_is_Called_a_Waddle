using UnityEngine;

public class SoundTrack : MonoBehaviour
{

    [SerializeField] AudioSource startAudio;
    [SerializeField] AudioSource loopedAudio;

    [SerializeField] AudioSource endAudio;
    
    void Start()
    {


        startAudio = GetComponent<AudioSource>();
        startAudio.Play();
        loopedAudio = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (!startAudio.isPlaying)
        {
            waiting();
        }
    }
    private void waiting()
    {
        while (startAudio.isPlaying)
        {
            return;
        }
        loopedAudio.Play();
    }
}
