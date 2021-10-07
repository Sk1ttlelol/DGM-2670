using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
   //private Transform parentObj;
   public GameObject prefab;
   //public IntData indexer;

   public void CreateInstance()
   {
      Instantiate(prefab);
   }
}
