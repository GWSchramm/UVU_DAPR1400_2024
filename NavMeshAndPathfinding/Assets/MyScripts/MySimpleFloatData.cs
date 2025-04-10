using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="poop/MySimpleFloatData")]
public class MySimpleFloatData : ScriptableObject
{
    public float value;

    public void UpdateValue(float amount)
    {
        value += amount;
    }

    public void SetValue(float amount)
    {
        value = amount;
    }

}
