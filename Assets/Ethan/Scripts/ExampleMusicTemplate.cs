using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public double musicDuration;
    public double goalTime;
    public AudioSource[] _audioSources;
    public int audioToggle;
    public AudioClip currentClip;
    public void Update()
    {
        if (AudioSettings.dspTime > goalTime - 1)
        {
            PlayScheduledClip();
        }
    }

    private void OnPlayMusic()
    {
        goalTime = AudioSettings.dspTime + 0.5;

        _audioSources[audioToggle].clip = currentClip;
        _audioSources[audioToggle].PlayScheduled(goalTime);

        musicDuration = (double)currentClip.samples / currentClip.frequency;
        goalTime += musicDuration;
    }


    private void PlayScheduledClip()
    {
        _audioSources[audioToggle].clip = currentClip;
        _audioSources[audioToggle].PlayScheduled(goalTime);

        musicDuration = (double)currentClip.samples / currentClip.frequency;
        goalTime += musicDuration;
        
        audioToggle = 1 - audioToggle;
    }

    
    public void SetCurrent(AudioClip clip)
    {
        currentClip = clip;

    }
}
