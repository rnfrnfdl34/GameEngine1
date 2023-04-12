using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float inch=3.0f;
        float cm=0.0f;
        cm = inch * 2.54f;
        Debug.Log(cm + "cm");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
