using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Ex03 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public float input_inch = 0.0f;
    void Start()
    {
        
        Debug.Log("1 inch = " + input_inch);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
