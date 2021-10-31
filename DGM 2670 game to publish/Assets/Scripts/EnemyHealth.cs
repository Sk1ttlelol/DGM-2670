using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
   public float enemyHealth = 10f;
   public LootTable thisDrop;
   public UnityEvent addScore;

   public Vector3 offset;
   

   
   private DealDamage dealDamageScript;


   public void RemoveHealth(float removeHealth)
   {
      enemyHealth -= removeHealth;

      if (enemyHealth <= 0)
      {
         CreateDrop();
         AddScore();
         EnemyDeath();
      }
   }
               // This and Loot Table SO found on YouTube from GameDevHQ "How to Create a Random Loot Table in Unity C#
   public void CreateDrop()
   {
      if (thisDrop != null)
      {
         GameObject current = thisDrop.GetPowerup();
         if (current != null)
         {
            Instantiate(current.gameObject, transform.position + offset, Quaternion.identity);
         }
      }
         
   }
   
   public void OnCollisionEnter(Collision other)
   {
      if (other.gameObject.CompareTag("Bullet"))
      {
         Debug.Log("EnemyHit" + enemyHealth);
         DealDamage dealDamageScript = other.gameObject.GetComponent<DealDamage>();
         RemoveHealth(dealDamageScript.damageEnemy);
         //RemoveHealth(damage);
      }
   }
   
   public void AddScore()
   {
      addScore.Invoke();
   }
   
   void EnemyDeath()
   {
      Destroy(gameObject);
   }
}
