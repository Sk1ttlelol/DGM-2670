using UnityEngine;
using UnityEngine.Events;

public class DealDamage : MonoBehaviour
{
    public float damageEnemy = 1f;
    public UnityEvent spawnEffects;
    
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            spawnEffects.Invoke();
            Destroy(gameObject);
        }
    }
}
