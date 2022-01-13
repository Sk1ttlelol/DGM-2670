using UnityEngine;
using UnityEngine.Events;

public class DealDamage : MonoBehaviour
{
    public float damageEnemy = 1f;
    public UnityEvent spawnEffects, addScore;
    
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            spawnEffects.Invoke();
            addScore.Invoke();
            Destroy(other.gameObject);
        }
        
        if (other.gameObject.CompareTag("Enemy"))
        {
            spawnEffects.Invoke();
            Destroy(gameObject);
        }
        
        
    }
}
