using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHealthContainer : MonoBehaviour
{
    public MySimpleFloatData healthData;

    public void ReduceHealth(float amount)
    {
        healthData.UpdateValue(amount);
    }
}
