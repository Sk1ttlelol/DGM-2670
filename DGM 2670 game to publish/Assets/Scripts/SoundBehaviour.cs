using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBehaviour : MonoBehaviour
{
    
    public AudioClip deathSound;
    public AudioSource enemyAudio;
   
    void Start()
    {
        
    }

    public void MakeSound()
    {
        enemyAudio.PlayOneShot(deathSound, 1.0f);
    }
}
