//flips a 2d sprite to face left or right depending on which button is pushed


using UnityEngine;


public class FlipTransformBehavior : MonoBehaviour
{
    public KeyCode key1 = KeyCode.D, key2 = KeyCode.A;
    public float direction1 = 0, direction2 = 180;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key1))
        {
            transform.rotation = Quaternion.Euler(0, direction1, 0);
        }

        if (Input.GetKeyDown(key2))
        {

            transform.rotation = Quaternion.Euler(0, direction2, 0);
        }
    }
}
