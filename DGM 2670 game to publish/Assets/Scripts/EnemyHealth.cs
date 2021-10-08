using UnityEngine;
using UnityEngine.Events;


public class EnemyHealth : MonoBehaviour
{
   public float enemyHealth = 10f;
   public LootTable thisDrop;
   public IntData score;
   public FloatData damage;
   public int scoreToAdd;

   public UnityEvent addScore;
   
   private DealDamage dealDamageScript;
   

   public void RemoveHealth(float removeHealth)
   {
      enemyHealth -= removeHealth;

      if (enemyHealth <= 0)
      {
         EnemyDeath();
         CreateDrop();
         AddScore();
      }
   }
               // This and Loot Table SO found on YouTube from GameDevHQ "How to Create a Random Loot Table in Unity C#
   private void CreateDrop()
   {
      if (thisDrop != null)
      {
         GameObject current = thisDrop.GetPowerup();
         if (current != null)
         {
            Instantiate(current.gameObject, transform.position, Quaternion.identity);
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

   void EnemyDeath()
   {
      Destroy(gameObject);
   }

   void AddScore()
   {
      addScore.Invoke();
   }
}
