using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    public float scaleFactor = 0.9f;

    private void OnCollisionEnter(Collision collision)
    {
        transform.localScale *= scaleFactor;
    }
}
