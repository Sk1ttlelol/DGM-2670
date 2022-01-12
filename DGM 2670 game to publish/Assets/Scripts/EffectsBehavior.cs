using UnityEngine;

public class EffectsBehavior : MonoBehaviour
{

    public GameObject FXprefab;
    public GameObject FXprefab2;
    public GameObject FXprefab3;
    

    private Vector3 Position;
    
  

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
