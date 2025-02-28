using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{


    public void DestroyItem(GameObject item)
    {
        Destroy(item);
    }
}
