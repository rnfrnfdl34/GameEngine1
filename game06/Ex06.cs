using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Ex06 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public int input_inch = 0;
    void Start()
    {
        float inch=2.54f;
        float a = input_inch * inch;
        Debug.Log(a + "cm");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}