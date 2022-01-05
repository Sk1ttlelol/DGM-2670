using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsBehavior : MonoBehaviour
{

    public GameObject FXprefab;
    public GameObject FXprefab2;
    public GameObject FXprefab3;

    private Vector3 Position;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Position;
    }

    public void SpawnEffect()
    {
        Instantiate(FXprefab, transform.position, Quaternion.identity);
    }
    
    public void SpawnEffect2()
    {
        Instantiate(FXprefab2, transform.position, Quaternion.identity);
    }
    
    public void SpawnEffect3()
    {
        Instantiate(FXprefab3, transform.position, Quaternion.identity);
    }
}
