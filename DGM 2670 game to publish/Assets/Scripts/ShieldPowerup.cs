using UnityEngine;
using UnityEngine.Events;

public class ShieldPowerup : MonoBehaviour
{
    public UnityEvent shieldTriggerEvent;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            shieldTriggerEvent.Invoke();
        }
        
        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(other.gameObject);
            shieldTriggerEvent.Invoke();
        }
    }
}
