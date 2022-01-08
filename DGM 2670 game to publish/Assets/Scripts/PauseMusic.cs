using UnityEngine;
using UnityEngine.Events;

public class PauseMusic : MonoBehaviour
{
    public AudioSource musicSource;
    public UnityEvent pauseMusic;
    private bool isPaused;
    void Start()
    {
        isPaused = false;
        musicSource = GetComponent<AudioSource>();
    }

    public void PauseTheMusic()
    {
        if (isPaused == false)
        {
            musicSource.Pause();
            isPaused = true;
            return;
        }

        if (isPaused)
        {
            musicSource.Play();
            isPaused = false;
            return;
        }
    }
}
