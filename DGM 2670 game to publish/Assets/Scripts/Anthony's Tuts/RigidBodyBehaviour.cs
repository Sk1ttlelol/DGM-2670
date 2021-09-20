using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidBodyBehaviour : MonoBehaviour
{
    public float force;
    
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.transform.Translate(Vector3.up * Time.deltaTime * force);
    }
    
}
