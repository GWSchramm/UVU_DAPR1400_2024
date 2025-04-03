using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySimpleIntData : MonoBehaviour
{
    public int value;

    public void UpdateValue(int amount)
    {
        value += amount;
    }

    public void SetValue(int amount)
    {
        value = amount;
    }

}
