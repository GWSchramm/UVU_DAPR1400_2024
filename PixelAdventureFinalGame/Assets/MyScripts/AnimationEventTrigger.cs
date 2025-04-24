using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventTrigger : MonoBehaviour
{
    public Animator animator;

    public void SetBool(string parameterName, bool value)
    {
        animator.SetBool(parameterName, value);
    }

    public void SetTrigger(string parameterName)
    {
        animator.SetTrigger(parameterName);
    }

}
