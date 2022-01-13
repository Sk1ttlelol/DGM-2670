using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBehaviour : MonoBehaviour
{
    
    public AudioClip deathSound, powerupSound, missleSound;
    public AudioSource enemyAudio, powerupAudio, missleAudio;
   
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

    public void MakeMissleSound()
    {
        missleAudio.PlayOneShot(missleSound, 1.0f);
    }
}
