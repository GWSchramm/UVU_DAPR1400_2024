using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;

public class MySimpleTMPBehaviour : MonoBehaviour
{
    private TextMeshProUGUI textObj;

    public MySimpleIntData dataObj;


    // Start is called before the first frame update
    void Start()
    {
        textObj = GetComponent<TextMeshProUGUI>();

        
    }

    public void Update()
    {
        textObj.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }

}
