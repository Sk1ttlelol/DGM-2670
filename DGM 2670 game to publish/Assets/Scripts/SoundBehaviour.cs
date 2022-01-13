using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBehaviour : MonoBehaviour
{
    
    public AudioClip deathSound, powerupSound;
    public AudioSource enemyAudio, powerupAudio;
   
    void Start()
    {
        
    }

    public void MakeEnemySound()
    {
        enemyAudio.PlayOneShot(deathSound, 1.0f);
    }

    public void MakePowerupSound()
    {
        powerupAudio.PlayOneShot(powerupSound, 1.0f);
    }
}
