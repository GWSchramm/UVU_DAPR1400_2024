using UnityEngine;

public class CollisionDetecter : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with " + collision.gameObject);
    }
}
