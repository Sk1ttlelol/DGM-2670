using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
   public float enemyHealth = 10f;
   public LootTable thisDrop;
   
   private DealDamage dealDamageScript;

   public void RemoveHealth(float removeHealth)
   {
      enemyHealth -= removeHealth;

      if (enemyHealth <= 0)
      {
         EnemyDeath();
         CreateDrop();
      }
   }

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
      }
   }

   void EnemyDeath()
   {
      Destroy(gameObject);
   }
}
