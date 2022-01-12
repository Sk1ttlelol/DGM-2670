using UnityEngine;

public class BulletSpawnManager : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float startDelay;
    public float repeatRate;

    public AudioClip bulletSound;
    private AudioSource playerAudio;
    private Vector3 spawnPos;
    public float yOffset;
    
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    private void Update()
    {
        spawnPos = transform.position;
    }

    void SpawnObstacle()
    {
        Instantiate(bulletPrefab, spawnPos, bulletPrefab.transform.rotation);
        //playerAudio.PlayOneShot(bulletSound, .1f);
    }
}
