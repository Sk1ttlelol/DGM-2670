using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{

  // public bool hasPowerUp = false;
  public GameObject powerUpIndicator;
  
  
  private void OnTriggerEnter(Collider other)
   {
      if(other.CompareTag("MiniShipPowerup"))
      {
         //hasPowerup = true;
         //Destroy(gameObject);
         Debug.Log("Powerup Collected!");
         StartCoroutine();
      }
   }

   public void StartCoroutine()
   {
      powerUpIndicator.gameObject.SetActive(true);
      StartCoroutine(PowerupCountdownRoutine());
   }
   
   IEnumerator PowerupCountdownRoutine()
   {
      yield return new WaitForSeconds(5);
      Debug.Log("Coroutine started");
      powerUpIndicator.gameObject.SetActive(false);
   }
}
