using UnityEngine;

public class ApplyForce : MonoBehaviour
{

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.right * 500);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
