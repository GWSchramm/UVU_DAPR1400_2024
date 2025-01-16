using UnityEngine;

public class ColorChange : MonoBehaviour
{
   // public Color newColor = Color.green;

    private void OnCollisionEnter(Collision collision)
    {
        Color randomColor = Random.ColorHSV();

        GetComponent<Renderer>().material.color = randomColor;
    }
}
