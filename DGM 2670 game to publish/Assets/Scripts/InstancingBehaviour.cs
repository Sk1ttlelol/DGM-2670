using UnityEngine;

public class InstancingBehaviour : MonoBehaviour
{
    //This script takes the object and spawns it based on the function it is tied to, in the case of the bullet it uses the Coroutine to determine how fast it spawns bullets
    public void OnInstance(GameObject obj)
    {
        Instantiate(obj);
    }
    
}
