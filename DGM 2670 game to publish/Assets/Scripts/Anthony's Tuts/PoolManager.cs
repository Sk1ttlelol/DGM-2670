using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
   public List<GameObject> pool;
   private int i;

   public void UseNext()
   {
      if (pool.Capacity > 0)
      {
         pool[i].SetActive(true);
      }
      
      if (pool.Capacity > 0 && i < pool.Count)
      {
         i++;
      }
      else
      {
         i = 0;
      }
   }
}
