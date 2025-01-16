using UnityEngine;

public class TransformController : MonoBehaviour
{
    void Update()
    {
        var x = Mathf.PingPong(Time.time, 2);
        var y = Mathf.PingPong(Time.time, 4);
        var p = new Vector3(x, y, 0);
        transform.position = p;

        transform.Rotate(new Vector3(30, 90, 0) * Time.deltaTime);
    }
}
