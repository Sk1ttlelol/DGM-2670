using UnityEngine.Events;
using UnityEngine;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent;
    public float speed;

    void Start()
    {
        startEvent.Invoke();
    }

    public void SpawnBullet()
    {
        transform.Translate(Vector3.down *Time.deltaTime * speed);
    }

}
