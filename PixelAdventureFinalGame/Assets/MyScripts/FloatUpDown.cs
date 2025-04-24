using UnityEngine;

public class FloatUpDown : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;       // Speed of movement
    [SerializeField] private float moveDistance = 1f;    // Distance from center
    [SerializeField] private bool moveHorizontally = false; // Toggle for left/right vs up/down

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * moveSpeed) * moveDistance;

        if (moveHorizontally)
        {
            transform.position = new Vector3(startPos.x + offset, startPos.y, startPos.z);
        }
        else
        {
            transform.position = new Vector3(startPos.x, startPos.y + offset, startPos.z);
        }
    }

    void OnDrawGizmos()
    {
        Vector3 center = Application.isPlaying ? startPos : transform.position;
        Vector3 direction = moveHorizontally ? Vector3.right : Vector3.up;

        Vector3 pointA = center + direction * moveDistance;
        Vector3 pointB = center - direction * moveDistance;

        // Draw the movement path
        Gizmos.color = Color.black;
        Gizmos.DrawLine(pointA, pointB);

        // Draw the center marker
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(center, 0.1f);
    }
}
